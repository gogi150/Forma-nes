namespace Windows_kontrola
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.cmbRun = new System.Windows.Forms.ComboBox();
            this.cbxAction = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(334, 37);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(119, 40);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run program";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cmbRun
            // 
            this.cmbRun.FormattingEnabled = true;
            this.cmbRun.Items.AddRange(new object[] {
            "Notepad",
            "Paint"});
            this.cmbRun.Location = new System.Drawing.Point(31, 44);
            this.cmbRun.Name = "cmbRun";
            this.cmbRun.Size = new System.Drawing.Size(137, 28);
            this.cmbRun.TabIndex = 2;
            this.cmbRun.SelectedIndexChanged += new System.EventHandler(this.cmbRun_SelectedIndexChanged);
            // 
            // cbxAction
            // 
            this.cbxAction.AutoSize = true;
            this.cbxAction.Location = new System.Drawing.Point(63, 229);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(185, 24);
            this.cbxAction.TabIndex = 3;
            this.cbxAction.Text = "Show program action";
            this.cbxAction.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRun);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Location = new System.Drawing.Point(63, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run a program";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 557);
            this.Controls.Add(this.cbxAction);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmbRun;
        private System.Windows.Forms.CheckBox cbxAction;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

