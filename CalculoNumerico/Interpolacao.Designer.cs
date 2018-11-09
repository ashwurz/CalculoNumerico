namespace CalculoNumerico
{
    partial class Interpolacao
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
            this.arrayX = new System.Windows.Forms.TextBox();
            this.arrayY = new System.Windows.Forms.TextBox();
            this.valorX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resposta = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrayX
            // 
            this.arrayX.Location = new System.Drawing.Point(209, 71);
            this.arrayX.Name = "arrayX";
            this.arrayX.Size = new System.Drawing.Size(341, 20);
            this.arrayX.TabIndex = 0;
            // 
            // arrayY
            // 
            this.arrayY.Location = new System.Drawing.Point(209, 130);
            this.arrayY.Name = "arrayY";
            this.arrayY.Size = new System.Drawing.Size(341, 20);
            this.arrayY.TabIndex = 1;
            // 
            // valorX
            // 
            this.valorX.Location = new System.Drawing.Point(319, 188);
            this.valorX.Name = "valorX";
            this.valorX.Size = new System.Drawing.Size(100, 20);
            this.valorX.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resposta
            // 
            this.resposta.Location = new System.Drawing.Point(209, 353);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(341, 20);
            this.resposta.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSistemas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSistemas
            // 
            this.btnSistemas.BackColor = System.Drawing.SystemColors.Control;
            this.btnSistemas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSistemas.ForeColor = System.Drawing.Color.Black;
            this.btnSistemas.Name = "btnSistemas";
            this.btnSistemas.Size = new System.Drawing.Size(117, 20);
            this.btnSistemas.Text = "Sistemas Lineares";
            this.btnSistemas.Click += new System.EventHandler(this.btnSistemas_Click);
            // 
            // Interpolacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorX);
            this.Controls.Add(this.arrayY);
            this.Controls.Add(this.arrayX);
            this.Name = "Interpolacao";
            this.Text = "Interpolacao";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayX;
        private System.Windows.Forms.TextBox arrayY;
        private System.Windows.Forms.TextBox valorX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resposta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSistemas;
    }
}