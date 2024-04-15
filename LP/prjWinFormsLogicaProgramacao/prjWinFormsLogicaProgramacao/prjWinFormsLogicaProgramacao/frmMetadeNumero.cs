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
    public partial class frmMetadeNumero : Form
    {
        public frmMetadeNumero()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            double numero1, metade;
            numero1 = Convert.ToDouble(txtNumero.Text);
            metade = numero1 / 2;
            if (numero1 >= 50)
            {
                txtResultado.Text = $"A metade do número {numero1} é {metade}.";
            }
            else
            {
                txtResultado.Text = "Informe um número maior que 50.";
            }

        }
    }
}
