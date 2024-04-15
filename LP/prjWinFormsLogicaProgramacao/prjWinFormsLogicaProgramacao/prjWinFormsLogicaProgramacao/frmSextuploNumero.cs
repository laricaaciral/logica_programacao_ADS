using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinFormsLogicaProgramacao
{
    public partial class frmSextuploNumero : Form
    {
        public frmSextuploNumero()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Double numero, sextuplo;
            numero=Convert.ToDouble(txtNumero.Text);
            if ((numero > 90))
            {
                sextuplo = numero * 6;
                txtResultado.Text = $"O número {numero} é maior que 90 e seu sêxtuplo é {sextuplo}.";
            }
            else
            {
                txtResultado.Text = $"Insira um número maior que 90.";
            }
        }
    }
}
