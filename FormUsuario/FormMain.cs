using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2;

namespace FormUsuario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDivCero_Click(object sender, EventArgs e)
        {
            FormDivision divcero = new FormDivision();
            divcero.txtDivisor.Enabled =false;

            divcero.ShowDialog();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FormDivision div = new FormDivision();
            div.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExc1_Click(object sender, EventArgs e)
        {
            CustomException CE = new CustomException();

            try
            {
                Logic.Excepcion(null, 1);

            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Una de las variables posee valor nulo \n"+ex,"Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExc2_Click(object sender, EventArgs e)
        {
            try
            {
                throw new CustomException();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Excepcion\n  "+ex.Message, "Excepcion Personalizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
