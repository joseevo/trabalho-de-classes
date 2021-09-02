namespace trabalho_de_classes
{
    partial class Menu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarAluguerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirClienteToolStripMenuItem,
            this.inserirVeiculoToolStripMenuItem,
            this.procurarClienteToolStripMenuItem,
            this.procurarVeiculoToolStripMenuItem,
            this.agendarAluguerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirClienteToolStripMenuItem
            // 
            this.inserirClienteToolStripMenuItem.Name = "inserirClienteToolStripMenuItem";
            this.inserirClienteToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.inserirClienteToolStripMenuItem.Text = "Inserir Cliente";
            this.inserirClienteToolStripMenuItem.Click += new System.EventHandler(this.inserirClienteToolStripMenuItem_Click_1);
            // 
            // inserirVeiculoToolStripMenuItem
            // 
            this.inserirVeiculoToolStripMenuItem.Name = "inserirVeiculoToolStripMenuItem";
            this.inserirVeiculoToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.inserirVeiculoToolStripMenuItem.Text = "Inserir Veiculo";
            this.inserirVeiculoToolStripMenuItem.Click += new System.EventHandler(this.inserirVeiculoToolStripMenuItem_Click);
            // 
            // procurarClienteToolStripMenuItem
            // 
            this.procurarClienteToolStripMenuItem.Name = "procurarClienteToolStripMenuItem";
            this.procurarClienteToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.procurarClienteToolStripMenuItem.Text = "Procurar Cliente";
            this.procurarClienteToolStripMenuItem.Click += new System.EventHandler(this.procurarClienteToolStripMenuItem_Click);
            // 
            // procurarVeiculoToolStripMenuItem
            // 
            this.procurarVeiculoToolStripMenuItem.Name = "procurarVeiculoToolStripMenuItem";
            this.procurarVeiculoToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.procurarVeiculoToolStripMenuItem.Text = "Procurar Veiculo";
            this.procurarVeiculoToolStripMenuItem.Click += new System.EventHandler(this.procurarVeiculoToolStripMenuItem_Click);
            // 
            // agendarAluguerToolStripMenuItem
            // 
            this.agendarAluguerToolStripMenuItem.Name = "agendarAluguerToolStripMenuItem";
            this.agendarAluguerToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.agendarAluguerToolStripMenuItem.Text = "Agendar Aluguer";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarAluguerToolStripMenuItem;
    }
}