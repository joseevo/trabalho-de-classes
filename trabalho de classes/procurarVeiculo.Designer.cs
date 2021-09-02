namespace trabalho_de_classes
{
    partial class procurarVeiculo
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
            this.dataVeic = new System.Windows.Forms.DataGridView();
            this.txtIdVeic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVeic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVeic
            // 
            this.dataVeic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVeic.Location = new System.Drawing.Point(0, 143);
            this.dataVeic.Name = "dataVeic";
            this.dataVeic.RowHeadersWidth = 51;
            this.dataVeic.RowTemplate.Height = 24;
            this.dataVeic.Size = new System.Drawing.Size(951, 390);
            this.dataVeic.TabIndex = 0;
            // 
            // txtIdVeic
            // 
            this.txtIdVeic.Location = new System.Drawing.Point(162, 53);
            this.txtIdVeic.Name = "txtIdVeic";
            this.txtIdVeic.Size = new System.Drawing.Size(309, 22);
            this.txtIdVeic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Veiculo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // procurarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdVeic);
            this.Controls.Add(this.dataVeic);
            this.Name = "procurarVeiculo";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataVeic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVeic;
        private System.Windows.Forms.TextBox txtIdVeic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}