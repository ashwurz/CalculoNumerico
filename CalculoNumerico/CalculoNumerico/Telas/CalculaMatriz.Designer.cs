namespace CalculoNumerico
{
    partial class CalculaMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculaMatriz));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLagrange = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDeGaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edtY = new System.Windows.Forms.TextBox();
            this.edtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarInversa = new System.Windows.Forms.Button();
            this.btnGerarTransposta = new System.Windows.Forms.Button();
            this.btnGerarDeterminante = new System.Windows.Forms.Button();
            this.groupBoxMatriz = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriaResultante = new System.Windows.Forms.Button();
            this.edtR = new System.Windows.Forms.TextBox();
            this.groupBoxResultante = new System.Windows.Forms.GroupBox();
            this.btnGerarFuncaoInv = new System.Windows.Forms.Button();
            this.btnGeraMultiplica = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLagrange,
            this.btnSistemas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLagrange
            // 
            this.btnLagrange.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLagrange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLagrange.ForeColor = System.Drawing.Color.Black;
            this.btnLagrange.Name = "btnLagrange";
            this.btnLagrange.Size = new System.Drawing.Size(89, 20);
            this.btnLagrange.Text = "Interpolação";
            this.btnLagrange.Click += new System.EventHandler(this.btnLagrange_Click);
            // 
            // btnSistemas
            // 
            this.btnSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.métodoDeGaussToolStripMenuItem});
            this.btnSistemas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSistemas.ForeColor = System.Drawing.Color.Black;
            this.btnSistemas.Name = "btnSistemas";
            this.btnSistemas.Size = new System.Drawing.Size(117, 20);
            this.btnSistemas.Text = "Sistemas Lineares";
            this.btnSistemas.Click += new System.EventHandler(this.btnSistemas_Click);
            // 
            // métodoDeGaussToolStripMenuItem
            // 
            this.métodoDeGaussToolStripMenuItem.Name = "métodoDeGaussToolStripMenuItem";
            this.métodoDeGaussToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.métodoDeGaussToolStripMenuItem.Text = "Método de Gauss";
            this.métodoDeGaussToolStripMenuItem.Click += new System.EventHandler(this.métodoDeGaussToolStripMenuItem_Click);
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.BackColor = System.Drawing.Color.White;
            this.btnCriarMatriz.ForeColor = System.Drawing.Color.Black;
            this.btnCriarMatriz.Location = new System.Drawing.Point(303, 54);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMatriz.TabIndex = 32;
            this.btnCriarMatriz.Text = "CriarMatriz";
            this.btnCriarMatriz.UseVisualStyleBackColor = false;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(209, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "x";
            // 
            // edtY
            // 
            this.edtY.BackColor = System.Drawing.Color.White;
            this.edtY.ForeColor = System.Drawing.Color.Black;
            this.edtY.Location = new System.Drawing.Point(239, 58);
            this.edtY.Name = "edtY";
            this.edtY.Size = new System.Drawing.Size(40, 20);
            this.edtY.TabIndex = 30;
            // 
            // edtX
            // 
            this.edtX.BackColor = System.Drawing.Color.White;
            this.edtX.ForeColor = System.Drawing.Color.Black;
            this.edtX.Location = new System.Drawing.Point(150, 58);
            this.edtX.Name = "edtX";
            this.edtX.Size = new System.Drawing.Size(40, 20);
            this.edtX.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Matriz";
            // 
            // btnGerarInversa
            // 
            this.btnGerarInversa.Location = new System.Drawing.Point(170, 386);
            this.btnGerarInversa.Name = "btnGerarInversa";
            this.btnGerarInversa.Size = new System.Drawing.Size(121, 23);
            this.btnGerarInversa.TabIndex = 34;
            this.btnGerarInversa.Text = "Gerar Inversa";
            this.btnGerarInversa.UseVisualStyleBackColor = true;
            this.btnGerarInversa.Click += new System.EventHandler(this.btnGerarInversa_Click);
            // 
            // btnGerarTransposta
            // 
            this.btnGerarTransposta.Location = new System.Drawing.Point(170, 356);
            this.btnGerarTransposta.Name = "btnGerarTransposta";
            this.btnGerarTransposta.Size = new System.Drawing.Size(121, 23);
            this.btnGerarTransposta.TabIndex = 35;
            this.btnGerarTransposta.Text = "Gerar Transposta";
            this.btnGerarTransposta.UseVisualStyleBackColor = true;
            this.btnGerarTransposta.Click += new System.EventHandler(this.btnGerarTransposta_Click);
            // 
            // btnGerarDeterminante
            // 
            this.btnGerarDeterminante.Location = new System.Drawing.Point(169, 327);
            this.btnGerarDeterminante.Name = "btnGerarDeterminante";
            this.btnGerarDeterminante.Size = new System.Drawing.Size(121, 23);
            this.btnGerarDeterminante.TabIndex = 37;
            this.btnGerarDeterminante.Text = "Gerar Determinante";
            this.btnGerarDeterminante.UseVisualStyleBackColor = true;
            this.btnGerarDeterminante.Click += new System.EventHandler(this.btnGerarDeterminante_Click);
            // 
            // groupBoxMatriz
            // 
            this.groupBoxMatriz.BackColor = System.Drawing.Color.White;
            this.groupBoxMatriz.ForeColor = System.Drawing.Color.Black;
            this.groupBoxMatriz.Location = new System.Drawing.Point(133, 94);
            this.groupBoxMatriz.Name = "groupBoxMatriz";
            this.groupBoxMatriz.Size = new System.Drawing.Size(208, 227);
            this.groupBoxMatriz.TabIndex = 33;
            this.groupBoxMatriz.TabStop = false;
            this.groupBoxMatriz.Text = "Matriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(426, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Matriz Resultante";
            // 
            // btnCriaResultante
            // 
            this.btnCriaResultante.BackColor = System.Drawing.Color.White;
            this.btnCriaResultante.ForeColor = System.Drawing.Color.Black;
            this.btnCriaResultante.Location = new System.Drawing.Point(629, 56);
            this.btnCriaResultante.Name = "btnCriaResultante";
            this.btnCriaResultante.Size = new System.Drawing.Size(75, 23);
            this.btnCriaResultante.TabIndex = 40;
            this.btnCriaResultante.Text = "CriarMatriz";
            this.btnCriaResultante.UseVisualStyleBackColor = false;
            this.btnCriaResultante.Click += new System.EventHandler(this.btnCriaResultante_Click);
            // 
            // edtR
            // 
            this.edtR.BackColor = System.Drawing.Color.White;
            this.edtR.ForeColor = System.Drawing.Color.Black;
            this.edtR.Location = new System.Drawing.Point(572, 58);
            this.edtR.Name = "edtR";
            this.edtR.Size = new System.Drawing.Size(40, 20);
            this.edtR.TabIndex = 39;
            // 
            // groupBoxResultante
            // 
            this.groupBoxResultante.BackColor = System.Drawing.Color.White;
            this.groupBoxResultante.ForeColor = System.Drawing.Color.Black;
            this.groupBoxResultante.Location = new System.Drawing.Point(476, 94);
            this.groupBoxResultante.Name = "groupBoxResultante";
            this.groupBoxResultante.Size = new System.Drawing.Size(121, 227);
            this.groupBoxResultante.TabIndex = 34;
            this.groupBoxResultante.TabStop = false;
            this.groupBoxResultante.Text = "Matriz Resultante";
            // 
            // btnGerarFuncaoInv
            // 
            this.btnGerarFuncaoInv.Location = new System.Drawing.Point(476, 356);
            this.btnGerarFuncaoInv.Name = "btnGerarFuncaoInv";
            this.btnGerarFuncaoInv.Size = new System.Drawing.Size(121, 23);
            this.btnGerarFuncaoInv.TabIndex = 42;
            this.btnGerarFuncaoInv.Text = "Calcular";
            this.btnGerarFuncaoInv.UseVisualStyleBackColor = true;
            this.btnGerarFuncaoInv.Click += new System.EventHandler(this.btnGerarFuncaoInv_Click);
            // 
            // btnGeraMultiplica
            // 
            this.btnGeraMultiplica.Location = new System.Drawing.Point(476, 327);
            this.btnGeraMultiplica.Name = "btnGeraMultiplica";
            this.btnGeraMultiplica.Size = new System.Drawing.Size(121, 23);
            this.btnGeraMultiplica.TabIndex = 43;
            this.btnGeraMultiplica.Text = "Multiplicar";
            this.btnGeraMultiplica.UseVisualStyleBackColor = true;
            this.btnGeraMultiplica.Click += new System.EventHandler(this.btnGeraMultiplica_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::CalculoNumerico.Properties.Resources._129_128;
            this.btnInfo.Location = new System.Drawing.Point(712, 348);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(76, 90);
            this.btnInfo.TabIndex = 44;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // CalculaMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGeraMultiplica);
            this.Controls.Add(this.btnGerarFuncaoInv);
            this.Controls.Add(this.groupBoxResultante);
            this.Controls.Add(this.btnCriaResultante);
            this.Controls.Add(this.edtR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerarInversa);
            this.Controls.Add(this.btnGerarTransposta);
            this.Controls.Add(this.btnGerarDeterminante);
            this.Controls.Add(this.groupBoxMatriz);
            this.Controls.Add(this.btnCriarMatriz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtY);
            this.Controls.Add(this.edtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculaMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas Lineares - Função Inversa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnLagrange;
        private System.Windows.Forms.ToolStripMenuItem btnSistemas;
        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtY;
        private System.Windows.Forms.TextBox edtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarInversa;
        private System.Windows.Forms.Button btnGerarTransposta;
        private System.Windows.Forms.Button btnGerarDeterminante;
        private System.Windows.Forms.GroupBox groupBoxMatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriaResultante;
        private System.Windows.Forms.TextBox edtR;
        private System.Windows.Forms.GroupBox groupBoxResultante;
        private System.Windows.Forms.Button btnGerarFuncaoInv;
        private System.Windows.Forms.Button btnGeraMultiplica;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolStripMenuItem métodoDeGaussToolStripMenuItem;
    }
}