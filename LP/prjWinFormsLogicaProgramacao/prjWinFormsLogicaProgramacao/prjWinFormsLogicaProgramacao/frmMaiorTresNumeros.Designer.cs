﻿namespace prjWinFormsLogicaProgramacao
{
    partial class frmMaiorTresNumeros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtEnunciado);
            this.groupBox1.Controls.Add(this.cmdCalcular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(410, 431);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exercício Maior de Três Números";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.ForeColor = System.Drawing.Color.Blue;
            this.txtResultado.Location = new System.Drawing.Point(15, 325);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(386, 91);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Entre com o 3ª Número";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 216);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entre com o 2ª Número";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 27);
            this.textBox1.TabIndex = 5;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.BackColor = System.Drawing.Color.Yellow;
            this.txtEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnunciado.Location = new System.Drawing.Point(15, 24);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(386, 73);
            this.txtEnunciado.TabIndex = 4;
            this.txtEnunciado.Text = "9. Faça um algoritmo que leia três números inteiros e determine qual dos três é m" +
    "aior";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(15, 260);
            this.cmdCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(386, 33);
            this.cmdCalcular.TabIndex = 2;
            this.cmdCalcular.Text = "Verificar o Maior de Três Números";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entre com o 1ª Número";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(195, 123);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(206, 27);
            this.txt1.TabIndex = 0;
            // 
            // frmMaiorTresNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMaiorTresNumeros";
            this.Text = "frmMaiorTresNumeros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtResultado;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtEnunciado;
        private Button cmdCalcular;
        private Label label1;
        private TextBox txt1;
    }
}