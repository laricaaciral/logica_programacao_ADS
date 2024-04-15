namespace prjWinFormsLogicaProgramacao
{
    partial class frmDobroNumero
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
            txtEnunciado = new TextBox();
            cmdCalcular = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtResultado);
            groupBox1.Controls.Add(txtEnunciado);
            groupBox1.Controls.Add(cmdCalcular);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 475);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exercício Dobro de um número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 301);
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
            txtResultado.Location = new Point(21, 332);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(441, 121);
            txtResultado.TabIndex = 9;
            txtResultado.Text = "Resultado";
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
            txtEnunciado.Text = "4. Crie um algoritmo que receba um número e mostre o número e o seu dobro somente quando o número for maior que noventa e menor que cem.";
            // 
            // cmdCalcular
            // 
            cmdCalcular.Location = new Point(21, 229);
            cmdCalcular.Name = "cmdCalcular";
            cmdCalcular.Size = new Size(441, 44);
            cmdCalcular.TabIndex = 2;
            cmdCalcular.Text = "Calcular Dobro do Número";
            cmdCalcular.UseVisualStyleBackColor = true;
            cmdCalcular.Click += cmdCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 167);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 1;
            label1.Text = "Entre com o Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(223, 164);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(235, 32);
            txtNumero.TabIndex = 0;
            // 
            // frmDobroNumero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 504);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDobroNumero";
            Text = "frmDobroNumero";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtResultado;
        private TextBox txtEnunciado;
        private Button cmdCalcular;
        private Label label1;
        private TextBox txtNumero;
    }
}