using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class FrmSolicitudParam : Form
    {
        public string Clave { get; set; }
        public string Valor { get; set; }
        public FrmSolicitudParam()
        {
            InitializeComponent();
        }



      
        private void Salir()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void Aceptar()
        {
            if (TxtClave.Text.Trim().Length == 0 || TxtValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            Clave = TxtClave.Text.Trim();
            Valor = TxtValor.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
