using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExercicio6Aula4
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void cmdCalcularMedia_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3, media;
            numero1=Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
            numero3 = Convert.ToDouble(txtNumero3.Text);
            media = (numero1+ numero2+numero3)/3;
            txtResultado.Text = "A média dos 3 números é " + media;
        }
    }
}
