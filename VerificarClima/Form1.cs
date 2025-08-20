using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificarClima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbTemperatura.Text, out double temperatura))
            {

                if (temperatura < 15)
                {
                    pibResultado.Image = Properties.Resources.Frio;
                }
                else if (!(temperatura < 15 || temperatura > 30))
                {
                    pibResultado.Image = Properties.Resources.SolNuvem;
                }
                else if (temperatura > 30)
                {
                    pibResultado.Image = Properties.Resources.Sol;
                }
                else
                {
                    MessageBox.Show("Digite uma temperatura válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);




                }
            }

        }
    }
}
