namespace prjWinFormsLogicaProgramacao
{
    partial class frmMediaTresNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            txtNota3 = new TextBox();
            label2 = new Label();
            txtNota2 = new TextBox();
            txtEnunciado = new TextBox();
            cmdCalcular = new Button();
            label1 = new Label();
            txtNota1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtResultado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNota3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNota2);
            groupBox1.Controls.Add(txtEnunciado);
            groupBox1.Controls.Add(cmdCalcular);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNota1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 575);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exercício Média de Três Números";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 404);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 10;
            label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(128, 255, 128);
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.ForeColor = Color.Blue;
            txtResultado.Location = new Point(17, 433);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(441, 121);
            txtResultado.TabIndex = 9;
            txtResultado.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 292);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 8;
            label3.Text = "Entre com o 3ª Nota";
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(223, 288);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(235, 32);
            txtNota3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 228);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 6;
            label2.Text = "Entre com o 2ª Nota";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(223, 224);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(235, 32);
            txtNota2.TabIndex = 5;
            // 
            // txtEnunciado
            // 
            txtEnunciado.BackColor = Color.Yellow;
            txtEnunciado.BorderStyle = BorderStyle.FixedSingle;
            txtEnunciado.Location = new Point(17, 32);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(441, 118);
            txtEnunciado.TabIndex = 4;
            txtEnunciado.Text = "2. Crie um algoritmo para que receba 3 notas, calcule a média das notas e caso a média for maior que 6 informe ao aluno que ele está aprovado ou reprovado.";
            // 
            // cmdCalcular
            // 
            cmdCalcular.Location = new Point(17, 347);
            cmdCalcular.Name = "cmdCalcular";
            cmdCalcular.Size = new Size(441, 44);
            cmdCalcular.TabIndex = 2;
            cmdCalcular.Text = "Calcular Média Notas";
            cmdCalcular.UseVisualStyleBackColor = true;
            cmdCalcular.Click += cmdCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 168);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 1;
            label1.Text = "Entre com o 1ª Nota";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(223, 164);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(235, 32);
            txtNota1.TabIndex = 0;
            txtNota1.TextChanged += txt1_TextChanged;
            // 
            // frmMediaTresNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 603);
            Controls.Add(groupBox1);
            Name = "frmMediaTresNotas";
            Text = "frmMeidaTresNotas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEnunciado;
        private Button cmdCalcular;
        private Label label1;
        private TextBox txtNota1;
        private Label label3;
        private TextBox txtNota3;
        private Label label2;
        private TextBox txtNota2;
        private Label label4;
        private TextBox txtResultado;
    }
}