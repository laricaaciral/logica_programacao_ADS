namespace prjExercicio6Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exerccio2M�diaDe3N�merosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 frmEx2 = new frmExercicio2();
            frmEx2.MdiParent = this;
            frmEx2.Show();
        }

        private void exerc�cio1AntecessorESucessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 frmEx1= new frmExercicio1();
            frmEx1.MdiParent = this;
            frmEx1.Show();

        }

        private void exerc�cio3MediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 frmEx3 = new frmExercicio3();
            frmEx3.MdiParent = this;
            frmEx3.Show();
        }

        private void exerc�cio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmexercicio4 frmEx4 = new frmexercicio4();
            frmEx4.MdiParent = this;
            frmEx4.Show();
        }

        private void exerc�cio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 frmEx5 = new frmExercicio5();
            frmEx5.MdiParent = this;
            frmEx5.Show();
        }
    }
}