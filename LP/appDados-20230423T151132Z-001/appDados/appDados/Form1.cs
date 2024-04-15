namespace appDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtresultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonenviar_Click(object sender, EventArgs e)
        {
            string nome, telefone, endereco;
            nome = txtnome.Text;
            telefone = txttelefone.Text;
            endereco = txtendereco.Text;

            txtresultados.Text += nome + ", " + telefone + ", " + endereco + ".\r\n";
            txtnome.Text = "";
            txttelefone.Text = "";
            txtendereco.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void lvlnome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}