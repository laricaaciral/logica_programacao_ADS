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
    public partial class frmDobroNumero : Form
    {
        public frmDobroNumero()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Int32 numero, dobro;
            numero = Convert.ToInt32(txtNumero.Text);
            if ((numero > 90) && (numero < 100)) ;
            {
                dobro = numero * 2;
                txtResultado.Text = $"O número {numero} é maior que " +
                                    $" 90 e menor que 100, e seu dobro é {dobro}.";
            }
        }
    }
}
