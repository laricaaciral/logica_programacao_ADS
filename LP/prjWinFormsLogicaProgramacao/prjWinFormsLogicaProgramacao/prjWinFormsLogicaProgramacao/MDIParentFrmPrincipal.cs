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
    public partial class MDIParentFrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIParentFrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exemploEstruturaCasoSwiftToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void classificaçãoDeUmTriânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício1Média3NotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMediaTresNotas frmMedia = new frmMediaTresNotas(); //instancia o form
            //Digo que o formulário MdiParent é o pai do formulário frmMedia
            frmMedia.MdiParent = this;
            //Após dizer qeu o formulário é filho uso o show para mostrar
            frmMedia.Show();
        }

        private void dobroDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDobroNumero frmdobro = new frmDobroNumero();
            frmdobro.MdiParent = this;
            frmdobro.Show();
        }

        private void exercícioEstruturaDeDecisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício15QuintaParteDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuintaParte frmQuinta = new frmQuintaParte();
            frmQuinta.MdiParent = this;
            frmQuinta.Show();
        }

        private void exercício6SêxtuploDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSextuploNumero frmSextuplo = new frmSextuploNumero();
            frmSextuplo.MdiParent = this;
            frmSextuplo.Show();
        }

        private void numeroParOuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumeroParImpar frmPar = new frmNumeroParImpar();
            frmPar.MdiParent = this;
            frmPar.Show();

        }

        private void exercícioMetadeDeUmNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetadeNumero frmMetade = new frmMetadeNumero();
            frmMetade.MdiParent = this;
            frmMetade.Show();
        }
    }
}
