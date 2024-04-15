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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Int32 numero, antecessor, sucessor;
            numero = Convert.ToInt32(txtNumero.Text);
            antecessor = numero - 1;
            sucessor = numero +1;
            txtAntecessor.Text = antecessor.ToString();
            txtSucessor.Text = sucessor.ToString();
        }
    }
}
