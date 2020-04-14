namespace Kraken.WinFormsBinding
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainView1 = new Kraken.WinFormsBinding.View.MainView();
            this.SuspendLayout();
            // 
            // mainView1
            // 
            this.mainView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView1.Location = new System.Drawing.Point(0, 0);
            this.mainView1.Name = "mainView1";
            this.mainView1.Size = new System.Drawing.Size(364, 391);
            this.mainView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.mainView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms-Binding";
            this.ResumeLayout(false);

        }

        #endregion

        private View.MainView mainView1;
    }
}

