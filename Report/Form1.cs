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
    public partial class Form1 : Form
    {

        StiReport report;
        Reporte reporte;
        public Form1()
        {
            InitializeComponent();
            report = new StiReport();
            using (var db = new DymContext())
            {
                reporte = db.Reporte.FirstOrDefault();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Diseñar
            var ds = GetDataSet("select * from Producto");
            //Add data to datastore
            report.RegData("DS", "DS", ds);
            //Fill dictionary
            report.Dictionary.Synchronize();
            report.Design();


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

        private void Button2_Click(object sender, EventArgs e)
        {
            //Leer from db 
            var ds = GetDataSet(reporte.Query);
            //Add data to datastore
            report.RegData("DS", "DS", ds);
            //Fill dictionary
            report.Dictionary.Synchronize();
            // report.LoadEncryptedReportFromString(reporte.Codigo, reporte.Nombre);
            report.Show();
            //code = report.SaveToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Guardar en db

            reporte.Codigo = report.SaveEncryptedReportToString("test"); ;
            //  reporte.Nombre = "test";
            reporte.Query = "select * from Producto";

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

        private void Button4_Click(object sender, EventArgs e)
        {
            var ds = GetDataSet(reporte.Query);
            //Add data to datastore
            report.RegData("DS", "DS", ds);
            //Fill dictionary
            report.Dictionary.Synchronize();
            // report.LoadEncryptedReportFromString(reporte.Codigo, reporte.Nombre);
            report.Design();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new FrmDisenador().Show();
        }
    }
}
