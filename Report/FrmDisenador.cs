using Report.Models;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class FrmDisenador : Form
    {
        //Controladores
        private ReporteController reporteController;

        //Objetos
        private StiReport stireport;
        private Reporte reporte;
        private DataSet ds;

        //Variables
        string s;
        int i;

        //Listas
        List<Parametro> parametros;
        public FrmDisenador()
        {
            InitializeComponent();
            reporteController = new ReporteController();
            parametros = new List<Parametro>();
            s = "";
            ds = null;
        }

        private void CrearNuevo()
        {
            TxtClave.Text = reporteController.GeneraClave();
            if (TxtDescripcion.Text.Trim().Length == 0 || TxtClave.Text.Trim().Length == 0 || TxtQuery.Text.Trim().Length == 0)
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            //Inicializa objetos
            stireport = new StiReport();
            reporte = new Reporte();

            reporte.Clave = TxtClave.Text.Trim();
            reporte.Query = TxtQuery.Text.Trim();
            reporte.Descripcion = TxtDescripcion.Text.Trim();
            reporte.Parametrizado = ChkParam.Checked;

            s = reporteController.PreparedStatement(reporte.Query, "@precio", "10");
            ds = reporteController.GetDataSet(s);

            //Add data to datastore
            stireport.RegData("DS", "DS", ds);
            //Fill dictionary
            stireport.Dictionary.Synchronize();
            stireport.Design();

        }
        private void Guardar()
        {
            if (reporte == null || stireport == null)
            {
                MessageBox.Show("No hay nada que guardar");
                return;
            }

            reporte.Codigo = stireport.SaveEncryptedReportToString(reporte.Clave);


            if (reporte.ReporteId == 0)
                reporteController.InsertOne(reporte);
            else
                reporteController.Update(reporte);

            MessageBox.Show("Cambios guardados");

        }
        private void Ver()
        {

            reporte = reporteController.SelectOne(1);
            TxtClave.Text = reporte.Clave;
            TxtQuery.Text = reporte.Query;
            TxtDescripcion.Text = reporte.Descripcion;
            ChkParam.Checked = reporte.Parametrizado;

            //Pregunta
            MessageBox.Show("Realmente quiere ver este reporte?");
            parametros = new List<Parametro>();
            for (int i = 0; i < Regex.Matches(reporte.Query, "@").Count; i++)
            {
                using (var form = new FrmSolicitudParam())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var p = new Parametro();
                        p.Clave = form.Clave;
                        p.Valor = form.Valor;
                        parametros.Add(p);
                    }
                }
            }

            if (parametros.Count == 1)
                s = reporteController.PreparedStatement(reporte.Query, parametros[0].Clave, parametros[0].Valor);

            if (parametros.Count == 2)
                s = reporteController.PreparedStatement(reporte.Query, parametros[0].Clave, parametros[0].Valor, parametros[1].Clave, parametros[1].Valor);

            ds = reporteController.GetDataSet(s);

            stireport = new StiReport();
            //Add data to datastore
            stireport.LoadEncryptedReportFromString(reporte.Codigo, reporte.Clave);
            stireport.RegData("DS", "DS", ds);
            //Fill dictionary
            stireport.Dictionary.Synchronize();
            stireport.Show();

        }
        private void Disenar()
        {
            reporte = reporteController.SelectOne(1);
            TxtClave.Text = reporte.Clave;
            TxtQuery.Text = reporte.Query;
            TxtDescripcion.Text = reporte.Descripcion;
            ChkParam.Checked = reporte.Parametrizado;

            //Pregunta
            MessageBox.Show("Realmente quiere editar este reporte?");
            parametros = new List<Parametro>();
            for (int i = 0; i < Regex.Matches(reporte.Query, "@").Count; i++)
            {
                using (var form = new FrmSolicitudParam())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var p = new Parametro();
                        p.Clave = form.Clave;
                        p.Valor = form.Valor;
                        parametros.Add(p);
                    }
                }
            }

            if (parametros.Count == 1)
                s = reporteController.PreparedStatement(reporte.Query, parametros[0].Clave, parametros[0].Valor);

            if (parametros.Count == 2)
                s = reporteController.PreparedStatement(reporte.Query, parametros[0].Clave, parametros[0].Valor, parametros[1].Clave, parametros[1].Valor);

            ds = reporteController.GetDataSet(s);

            stireport = new StiReport();
            //Add data to datastore
            stireport.LoadEncryptedReportFromString(reporte.Codigo, reporte.Clave);
            stireport.RegData("DS", "DS", ds);
            //Fill dictionary
            stireport.Dictionary.Synchronize();
            stireport.Design();
            //ok
        } 

        #region Eventos


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CrearNuevo();
        }


        private void BtnVer_Click(object sender, EventArgs e)
        {
            Ver();
        }
        private void BtnDisenar_Click(object sender, EventArgs e)
        {
            Disenar();
        }
        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
