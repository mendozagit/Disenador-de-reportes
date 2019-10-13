using Report.Models;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class FrmReporteador : Form
    {
        StiReport stireport;
        Reporte reporte;
        public FrmReporteador()
        {
            InitializeComponent();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (TxtQuery.Text.Trim().Length == 0)
            {
                MessageBox.Show("Llena query");
                return;
            }

            //Diseñar
            var sql = preparaSql(TxtQuery.Text.Trim(), "@precio", 10);
            var ds = GetDataSet(sql);
            if (stireport == null)
                stireport = new StiReport();

            //Add data to datastore
            stireport.RegData("DS", "DS", ds);
            //Fill dictionary
            stireport.Dictionary.Synchronize();
            stireport.Design();
        }
        private string preparaSql(string query, string nombrep, decimal valorp)
        {
            var s = query.Replace(nombrep, valorp + "");
            return s;
        }

        private void BtnDisenar_Click(object sender, EventArgs e)
        {
            if (stireport != null)
            {
                stireport.Dictionary.Synchronize();
                stireport.Design();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            var sql = preparaSql(reporte.Query, "@precio", 20);
            var ds = GetDataSet(sql);

            stireport = new StiReport();
            //Add data to datastore
            stireport.RegData("DS", "DS", ds);
            //Fill dictionary
            stireport.Dictionary.Synchronize();
            stireport.LoadEncryptedReportFromString(reporte.Codigo, reporte.Clave);
            stireport.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDescrip.Text.Trim().Length == 0 || TxtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("Llene todos loca campos");
                return;
            }


            if (reporte == null)
                reporte = new Reporte();


            reporte.Clave = TxtClave.Text.Trim();
            reporte.Codigo = stireport.SaveEncryptedReportToString(reporte.Clave);
            reporte.Descripcion = TxtDescrip.Text.Trim();
            reporte.Query = TxtQuery.Text.Trim();

            using (var db = new DymContext())
            {
                if (reporte.ReporteId == 0)
                    db.Add(reporte);
                else
                    db.Update(reporte);

                db.SaveChanges();
                MessageBox.Show("Guardado");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DymContext())
            {
                reporte = db.Reporte.FirstOrDefault(x => x.Descripcion.Equals(CboReporte.Text));

            }
        }

        private void CargarCombo()
        {
            using (var db = new DymContext())
            {
                foreach (var r in db.Reporte.ToList())
                {
                    CboReporte.Items.Add(r.Descripcion);
                }
            }
        }
        public DataSet GetDataSet(string SQL)
        {
            string ConnectionString = @"Server=.\SQLEXPRESS;Database=Dym;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }
        private void FrmReporteador_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
    }
}
