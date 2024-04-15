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
    public partial class frmNumeroParImpar : Form
    {
        public frmNumeroParImpar()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Int32 numero;
            numero=Convert.ToInt32(txtNumero.Text);
            if (numero % 2 == 0) 
            {
                txtResultado.Text = $"O número {numero} é par.";
            } else
            {
                txtResultado.Text = $"O número {numero} é ímpar.";
            }
        }
    }
}
