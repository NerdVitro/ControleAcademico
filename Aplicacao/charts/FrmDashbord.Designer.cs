namespace charts
{
    partial class FrmDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashbord));
            this.BtnAbrirGrafico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAbrirGrafico
            // 
            this.BtnAbrirGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirGrafico.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirGrafico.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAbrirGrafico.Location = new System.Drawing.Point(15, 13);
            this.BtnAbrirGrafico.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnAbrirGrafico.Name = "BtnAbrirGrafico";
            this.BtnAbrirGrafico.Size = new System.Drawing.Size(162, 50);
            this.BtnAbrirGrafico.TabIndex = 2;
            this.BtnAbrirGrafico.Text = "Abrir Grafico";
            this.BtnAbrirGrafico.UseVisualStyleBackColor = true;
            this.BtnAbrirGrafico.Click += new System.EventHandler(this.BtnAbrirGrafico_Click);
            // 
            // FrmDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAbrirGrafico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrirGrafico;
    }
}