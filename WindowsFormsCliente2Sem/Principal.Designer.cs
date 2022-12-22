namespace WindowsFormsCliente2Sem
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cANCELADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASDSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASDASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCLUIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 386);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cANCELADOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cANCELADOToolStripMenuItem
            // 
            this.cANCELADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dASDSAToolStripMenuItem,
            this.dASDASDToolStripMenuItem,
            this.cONSULTAToolStripMenuItem,
            this.eXCLUIRToolStripMenuItem});
            this.cANCELADOToolStripMenuItem.Name = "cANCELADOToolStripMenuItem";
            this.cANCELADOToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cANCELADOToolStripMenuItem.Text = "Cliente";
            // 
            // dASDSAToolStripMenuItem
            // 
            this.dASDSAToolStripMenuItem.Name = "dASDSAToolStripMenuItem";
            this.dASDSAToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dASDSAToolStripMenuItem.Text = "Cadastro";
            this.dASDSAToolStripMenuItem.Click += new System.EventHandler(this.dASDSAToolStripMenuItem_Click);
            // 
            // dASDASDToolStripMenuItem
            // 
            this.dASDASDToolStripMenuItem.Name = "dASDASDToolStripMenuItem";
            this.dASDASDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dASDASDToolStripMenuItem.Text = "Atualização de cadastro";
            this.dASDASDToolStripMenuItem.Click += new System.EventHandler(this.dASDASDToolStripMenuItem_Click);
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cONSULTAToolStripMenuItem.Text = "Consultar cliente";
            this.cONSULTAToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAToolStripMenuItem_Click);
            // 
            // eXCLUIRToolStripMenuItem
            // 
            this.eXCLUIRToolStripMenuItem.Name = "eXCLUIRToolStripMenuItem";
            this.eXCLUIRToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.eXCLUIRToolStripMenuItem.Text = "Excluir cliente";
            this.eXCLUIRToolStripMenuItem.Click += new System.EventHandler(this.eXCLUIRToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cANCELADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASDSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASDASDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCLUIRToolStripMenuItem;
    }
}