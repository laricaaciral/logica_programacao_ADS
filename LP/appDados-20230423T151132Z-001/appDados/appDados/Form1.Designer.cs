namespace appDados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            buttonenviar = new Button();
            txtresultados = new TextBox();
            txtendereco = new TextBox();
            lblendereco = new Label();
            txttelefone = new TextBox();
            lbltelefone = new Label();
            txtnome = new TextBox();
            lvlnome = new Label();
            label1 = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(buttonenviar);
            groupBox.Controls.Add(txtresultados);
            groupBox.Controls.Add(txtendereco);
            groupBox.Controls.Add(lblendereco);
            groupBox.Controls.Add(txttelefone);
            groupBox.Controls.Add(lbltelefone);
            groupBox.Controls.Add(txtnome);
            groupBox.Controls.Add(lvlnome);
            groupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Location = new Point(14, 16);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(853, 357);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Cadastro de Dados Pessoais";
            groupBox.Enter += groupBox_Enter;
            // 
            // buttonenviar
            // 
            buttonenviar.Location = new Point(27, 262);
            buttonenviar.Margin = new Padding(3, 4, 3, 4);
            buttonenviar.Name = "buttonenviar";
            buttonenviar.Size = new Size(794, 48);
            buttonenviar.TabIndex = 7;
            buttonenviar.Text = "Cadastrar";
            buttonenviar.UseVisualStyleBackColor = true;
            buttonenviar.Click += buttonenviar_Click;
            // 
            // txtresultados
            // 
            txtresultados.Location = new Point(378, 63);
            txtresultados.Margin = new Padding(3, 4, 3, 4);
            txtresultados.Multiline = true;
            txtresultados.Name = "txtresultados";
            txtresultados.ScrollBars = ScrollBars.Both;
            txtresultados.Size = new Size(443, 174);
            txtresultados.TabIndex = 6;
            txtresultados.TextChanged += txtresultados_TextChanged;
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(27, 203);
            txtendereco.Margin = new Padding(3, 4, 3, 4);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(282, 34);
            txtendereco.TabIndex = 5;
            // 
            // lblendereco
            // 
            lblendereco.AutoSize = true;
            lblendereco.Location = new Point(27, 171);
            lblendereco.Name = "lblendereco";
            lblendereco.Size = new Size(99, 28);
            lblendereco.TabIndex = 4;
            lblendereco.Text = "Endereço";
            lblendereco.Click += label3_Click;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(27, 133);
            txttelefone.Margin = new Padding(3, 4, 3, 4);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(282, 34);
            txttelefone.TabIndex = 3;
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(27, 101);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(93, 28);
            lbltelefone.TabIndex = 2;
            lbltelefone.Text = "Telefone";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(27, 63);
            txtnome.Margin = new Padding(3, 4, 3, 4);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(282, 34);
            txtnome.TabIndex = 1;
            // 
            // lvlnome
            // 
            lvlnome.AutoSize = true;
            lvlnome.Location = new Point(27, 31);
            lvlnome.Name = "lvlnome";
            lvlnome.Size = new Size(69, 28);
            lvlnome.TabIndex = 0;
            lvlnome.Text = "Nome";
            lvlnome.Click += lvlnome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 31);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 8;
            label1.Text = "Dados Cadastrados";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 391);
            Controls.Add(groupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Button buttonenviar;
        private TextBox txtresultados;
        private TextBox txtendereco;
        private Label lblendereco;
        private TextBox txttelefone;
        private Label lbltelefone;
        private TextBox txtnome;
        private Label lvlnome;
        private Label label1;
    }
}