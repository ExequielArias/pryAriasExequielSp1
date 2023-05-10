namespace pryAriasExequielSp1
{
    partial class frmSinterpartSRL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinterpartSRL));
            this.lblBienvenidoASintepartSRL = new System.Windows.Forms.Label();
            this.cmdComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenidoASintepartSRL
            // 
            this.lblBienvenidoASintepartSRL.AutoSize = true;
            this.lblBienvenidoASintepartSRL.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoASintepartSRL.Location = new System.Drawing.Point(50, 46);
            this.lblBienvenidoASintepartSRL.Name = "lblBienvenidoASintepartSRL";
            this.lblBienvenidoASintepartSRL.Size = new System.Drawing.Size(374, 39);
            this.lblBienvenidoASintepartSRL.TabIndex = 0;
            this.lblBienvenidoASintepartSRL.Text = "Bienvenido a Sintepart SRL";
            // 
            // cmdComenzar
            // 
            this.cmdComenzar.Location = new System.Drawing.Point(172, 147);
            this.cmdComenzar.Name = "cmdComenzar";
            this.cmdComenzar.Size = new System.Drawing.Size(118, 22);
            this.cmdComenzar.TabIndex = 1;
            this.cmdComenzar.Text = "Comenzar";
            this.cmdComenzar.UseVisualStyleBackColor = true;
            this.cmdComenzar.Click += new System.EventHandler(this.cmdComenzar_Click);
            // 
            // frmSinterpartSRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 209);
            this.Controls.Add(this.cmdComenzar);
            this.Controls.Add(this.lblBienvenidoASintepartSRL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSinterpartSRL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sintepart SRL";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidoASintepartSRL;
        private System.Windows.Forms.Button cmdComenzar;
    }
}