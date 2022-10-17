namespace primjenaWindowsKontrola
{
    partial class FormaText
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
            this.txtbProgramDescription = new System.Windows.Forms.TextBox();
            this.lblProgramDescription = new System.Windows.Forms.Label();
            this.txtbProgramName = new System.Windows.Forms.TextBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbProgramDescription
            // 
            this.txtbProgramDescription.Location = new System.Drawing.Point(120, 72);
            this.txtbProgramDescription.Multiline = true;
            this.txtbProgramDescription.Name = "txtbProgramDescription";
            this.txtbProgramDescription.Size = new System.Drawing.Size(177, 77);
            this.txtbProgramDescription.TabIndex = 7;
            // 
            // lblProgramDescription
            // 
            this.lblProgramDescription.AutoSize = true;
            this.lblProgramDescription.Location = new System.Drawing.Point(9, 72);
            this.lblProgramDescription.Name = "lblProgramDescription";
            this.lblProgramDescription.Size = new System.Drawing.Size(103, 13);
            this.lblProgramDescription.TabIndex = 6;
            this.lblProgramDescription.Text = "Program description:";
            // 
            // txtbProgramName
            // 
            this.txtbProgramName.Location = new System.Drawing.Point(120, 19);
            this.txtbProgramName.Name = "txtbProgramName";
            this.txtbProgramName.Size = new System.Drawing.Size(177, 20);
            this.txtbProgramName.TabIndex = 5;
            this.txtbProgramName.TextChanged += new System.EventHandler(this.txtbProgramName_TextChanged);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(9, 19);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(78, 13);
            this.lblProgramName.TabIndex = 4;
            this.lblProgramName.Text = "Program name:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 211);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(222, 211);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // FormaText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 246);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtbProgramDescription);
            this.Controls.Add(this.lblProgramDescription);
            this.Controls.Add(this.txtbProgramName);
            this.Controls.Add(this.lblProgramName);
            this.Name = "FormaText";
            this.Text = "FormaText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbProgramDescription;
        private System.Windows.Forms.Label lblProgramDescription;
        private System.Windows.Forms.TextBox txtbProgramName;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancle;
    }
}