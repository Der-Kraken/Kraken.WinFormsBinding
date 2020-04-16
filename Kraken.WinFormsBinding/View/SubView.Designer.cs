namespace Kraken.WinFormsBinding.View
{
    partial class SubView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerationLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subSubView1 = new Kraken.WinFormsBinding.View.SubSubView();
            this.NewSubSubVMBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberTxt
            // 
            this.NumberTxt.Location = new System.Drawing.Point(16, 42);
            this.NumberTxt.Name = "NumberTxt";
            this.NumberTxt.Size = new System.Drawing.Size(86, 20);
            this.NumberTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SubView";
            // 
            // GenerationLbl
            // 
            this.GenerationLbl.AutoSize = true;
            this.GenerationLbl.Location = new System.Drawing.Point(87, 12);
            this.GenerationLbl.Name = "GenerationLbl";
            this.GenerationLbl.Size = new System.Drawing.Size(35, 13);
            this.GenerationLbl.TabIndex = 2;
            this.GenerationLbl.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // subSubView1
            // 
            this.subSubView1.Location = new System.Drawing.Point(16, 101);
            this.subSubView1.Name = "subSubView1";
            this.subSubView1.Size = new System.Drawing.Size(111, 55);
            this.subSubView1.TabIndex = 4;
            // 
            // NewSubSubVMBtn
            // 
            this.NewSubSubVMBtn.Location = new System.Drawing.Point(16, 72);
            this.NewSubSubVMBtn.Name = "NewSubSubVMBtn";
            this.NewSubSubVMBtn.Size = new System.Drawing.Size(106, 23);
            this.NewSubSubVMBtn.TabIndex = 5;
            this.NewSubSubVMBtn.Text = "New SubSubVM";
            this.NewSubSubVMBtn.UseVisualStyleBackColor = true;
            this.NewSubSubVMBtn.Click += new System.EventHandler(this.NewSubSubVMBtn_Click);
            // 
            // SubView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewSubSubVMBtn);
            this.Controls.Add(this.subSubView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenerationLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTxt);
            this.Name = "SubView";
            this.Size = new System.Drawing.Size(134, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GenerationLbl;
        private System.Windows.Forms.Button button1;
        private SubSubView subSubView1;
        private System.Windows.Forms.Button NewSubSubVMBtn;
    }
}
