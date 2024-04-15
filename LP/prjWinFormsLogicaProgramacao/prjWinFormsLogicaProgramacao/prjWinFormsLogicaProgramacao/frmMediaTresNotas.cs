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
    public partial class frmMediaTresNotas : Form
    {
        public frmMediaTresNotas()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            if (media > 6)
            {
                txtResultado.Text = "O aluno está aprovado.";
            }
            else
            {
                txtResultado.Text = "O aluno está reprovado.";
            }

        }
    }
}
