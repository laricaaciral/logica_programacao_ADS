namespace prjExercicio6Aula4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercício6Aula4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1AntecessorESucessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerccio2MédiaDe3NúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício3MediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício6Aula4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercício6Aula4ToolStripMenuItem
            // 
            this.exercício6Aula4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1AntecessorESucessorToolStripMenuItem,
            this.exerccio2MédiaDe3NúmerosToolStripMenuItem,
            this.exercício3MediaToolStripMenuItem,
            this.exercício4ToolStripMenuItem,
            this.exercício5ToolStripMenuItem});
            this.exercício6Aula4ToolStripMenuItem.Name = "exercício6Aula4ToolStripMenuItem";
            this.exercício6Aula4ToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.exercício6Aula4ToolStripMenuItem.Text = "Exercício 6 Aula 4";
            // 
            // exercício1AntecessorESucessorToolStripMenuItem
            // 
            this.exercício1AntecessorESucessorToolStripMenuItem.Name = "exercício1AntecessorESucessorToolStripMenuItem";
            this.exercício1AntecessorESucessorToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exercício1AntecessorESucessorToolStripMenuItem.Text = "Exercício 1 - Antecessor e Sucessor";
            this.exercício1AntecessorESucessorToolStripMenuItem.Click += new System.EventHandler(this.exercício1AntecessorESucessorToolStripMenuItem_Click);
            // 
            // exerccio2MédiaDe3NúmerosToolStripMenuItem
            // 
            this.exerccio2MédiaDe3NúmerosToolStripMenuItem.Name = "exerccio2MédiaDe3NúmerosToolStripMenuItem";
            this.exerccio2MédiaDe3NúmerosToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exerccio2MédiaDe3NúmerosToolStripMenuItem.Text = "Exercício 2 - Média de 3 números";
            this.exerccio2MédiaDe3NúmerosToolStripMenuItem.Click += new System.EventHandler(this.exerccio2MédiaDe3NúmerosToolStripMenuItem_Click);
            // 
            // exercício3MediaToolStripMenuItem
            // 
            this.exercício3MediaToolStripMenuItem.Name = "exercício3MediaToolStripMenuItem";
            this.exercício3MediaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exercício3MediaToolStripMenuItem.Text = "Exercício 3 - Média de 4 notas ";
            this.exercício3MediaToolStripMenuItem.Click += new System.EventHandler(this.exercício3MediaToolStripMenuItem_Click);
            // 
            // exercício4ToolStripMenuItem
            // 
            this.exercício4ToolStripMenuItem.Name = "exercício4ToolStripMenuItem";
            this.exercício4ToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exercício4ToolStripMenuItem.Text = "Exercício 4 - Reajuste de Aplicação";
            this.exercício4ToolStripMenuItem.Click += new System.EventHandler(this.exercício4ToolStripMenuItem_Click);
            // 
            // exercício5ToolStripMenuItem
            // 
            this.exercício5ToolStripMenuItem.Name = "exercício5ToolStripMenuItem";
            this.exercício5ToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exercício5ToolStripMenuItem.Text = "Exercício 5 - Área do Trapézio";
            this.exercício5ToolStripMenuItem.Click += new System.EventHandler(this.exercício5ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercício6Aula4ToolStripMenuItem;
        private ToolStripMenuItem exercício1AntecessorESucessorToolStripMenuItem;
        private ToolStripMenuItem exerccio2MédiaDe3NúmerosToolStripMenuItem;
        private ToolStripMenuItem exercício3MediaToolStripMenuItem;
        private ToolStripMenuItem exercício4ToolStripMenuItem;
        private ToolStripMenuItem exercício5ToolStripMenuItem;
    }
}