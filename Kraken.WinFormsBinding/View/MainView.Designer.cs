namespace Kraken.WinFormsBinding.View
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subViewSingleton = new Kraken.WinFormsBinding.View.SubView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subViewNewest = new Kraken.WinFormsBinding.View.SubView();
            this.NewSubViewModelBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SingletonSubViewModelTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewestSubViewModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.subViewNewestClone = new Kraken.WinFormsBinding.View.SubView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.subViewSingletonClone = new Kraken.WinFormsBinding.View.SubView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subViewSingleton);
            this.groupBox1.Location = new System.Drawing.Point(18, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Singleton SubViewModel";
            // 
            // subViewSingleton
            // 
            this.subViewSingleton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subViewSingleton.Location = new System.Drawing.Point(3, 16);
            this.subViewSingleton.Name = "subViewSingleton";
            this.subViewSingleton.Size = new System.Drawing.Size(141, 81);
            this.subViewSingleton.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subViewNewest);
            this.groupBox2.Location = new System.Drawing.Point(193, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Newest SubViewModel";
            // 
            // subViewNewest
            // 
            this.subViewNewest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subViewNewest.Location = new System.Drawing.Point(3, 16);
            this.subViewNewest.Name = "subViewNewest";
            this.subViewNewest.Size = new System.Drawing.Size(140, 81);
            this.subViewNewest.TabIndex = 1;
            // 
            // NewSubViewModelBtn
            // 
            this.NewSubViewModelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewSubViewModelBtn.Location = new System.Drawing.Point(3, 16);
            this.NewSubViewModelBtn.Name = "NewSubViewModelBtn";
            this.NewSubViewModelBtn.Size = new System.Drawing.Size(348, 33);
            this.NewSubViewModelBtn.TabIndex = 7;
            this.NewSubViewModelBtn.Text = "Create New SubViewModel";
            this.NewSubViewModelBtn.UseVisualStyleBackColor = true;
            this.NewSubViewModelBtn.Click += new System.EventHandler(this.NewSubViewModelBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SingletonSubViewModelTxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.NewestSubViewModel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.NewSubViewModelBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 106);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MainViewModel";
            // 
            // SingletonSubViewModelTxt
            // 
            this.SingletonSubViewModelTxt.Location = new System.Drawing.Point(31, 73);
            this.SingletonSubViewModelTxt.Name = "SingletonSubViewModelTxt";
            this.SingletonSubViewModelTxt.Size = new System.Drawing.Size(100, 20);
            this.SingletonSubViewModelTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Singleton Number";
            // 
            // NewestSubViewModel
            // 
            this.NewestSubViewModel.Location = new System.Drawing.Point(228, 73);
            this.NewestSubViewModel.Name = "NewestSubViewModel";
            this.NewestSubViewModel.Size = new System.Drawing.Size(100, 20);
            this.NewestSubViewModel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Newest Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.subViewNewestClone);
            this.groupBox4.Location = new System.Drawing.Point(196, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clone Newest SubVM";
            // 
            // subViewNewestClone
            // 
            this.subViewNewestClone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subViewNewestClone.Location = new System.Drawing.Point(3, 16);
            this.subViewNewestClone.Name = "subViewNewestClone";
            this.subViewNewestClone.Size = new System.Drawing.Size(137, 81);
            this.subViewNewestClone.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.subViewSingletonClone);
            this.groupBox5.Location = new System.Drawing.Point(18, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(147, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clone Singleton SubVM";
            // 
            // subViewSingletonClone
            // 
            this.subViewSingletonClone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subViewSingletonClone.Location = new System.Drawing.Point(3, 16);
            this.subViewSingletonClone.Name = "subViewSingletonClone";
            this.subViewSingletonClone.Size = new System.Drawing.Size(141, 81);
            this.subViewSingletonClone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "----------------------------------------------";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(354, 384);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SubView subViewNewest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NewSubViewModelBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NewestSubViewModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SingletonSubViewModelTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private SubView subViewNewestClone;
        private System.Windows.Forms.GroupBox groupBox5;
        private SubView subViewSingletonClone;
        private SubView subViewSingleton;
        private System.Windows.Forms.Label label1;
    }
}