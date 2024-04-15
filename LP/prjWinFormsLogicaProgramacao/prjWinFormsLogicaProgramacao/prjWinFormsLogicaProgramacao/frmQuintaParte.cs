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
    public partial class frmQuintaParte : Form
    {
        public frmQuintaParte()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Double numero, quintaParte;
            numero=Convert.ToDouble(txtNumero.Text);
            if ((numero < 50) || (numero > 1000))
            {
                quintaParte = numero / 5;
                txtResultado.Text = $"O número {numero} é menor que 50 " +
                                    $"OU maior que 1000 e sua quinta parte é {quintaParte}.";
            }else
            {
                txtResultado.Text = $"Insira um número menor que 50 ou maior que 1000.";
            }
        }
    }
}


