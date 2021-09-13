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
    public partial class FormDivision : Form
    {
        public FormDivision()
        {
            InitializeComponent();
        }

         void FormDivision_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            try
            {
            if (txtDivisor.Enabled ==false)
            {

                    MessageBox.Show("El resultado es: " + OperacionesExtension.Dividir(dividendo) , "Resultado", MessageBoxButtons.OK);

            }
                else
                {
                    int divisor = Convert.ToInt32(txtDivisor.Text);
                    MessageBox.Show("El resultado es: " + OperacionesExtension.Dividir(dividendo, divisor), "Resultado", MessageBoxButtons.OK);

                    /*En este caso no se como hacer para que entre en el catch cuando divido por 0, si declaro las variables como int entra
                    pero hace mal la operacion. Si las declaro como float / double hace bien la division, pero no entre en el catch
                     En el metodo "DivisionPorCero" en UnitTest se puede observar que el test no funciona al no tirar la excepcion */
                }

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("A jakiado la NASA exitosamente","Felicidades"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            catch (FormatException)
            { 
            
                MessageBox.Show("Ingreso una letra o no ingreso nada", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }
    }
}
