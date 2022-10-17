namespace primjenaWindowsKontrola
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tslFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tslEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.tslView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tslHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRunProgram = new System.Windows.Forms.GroupBox();
            this.cmbRunProgram = new System.Windows.Forms.ComboBox();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.chbShowProgramAction = new System.Windows.Forms.CheckBox();
            this.gbProgramControl = new System.Windows.Forms.GroupBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.txtbProgramName = new System.Windows.Forms.TextBox();
            this.txtbProgramDescription = new System.Windows.Forms.TextBox();
            this.lblProgramDescription = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.gbRunProgram.SuspendLayout();
            this.gbProgramControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFile,
            this.tslEdit,
            this.tslView,
            this.tslHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(343, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tslFile
            // 
            this.tslFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiExit});
            this.tslFile.Name = "tslFile";
            this.tslFile.Size = new System.Drawing.Size(38, 22);
            this.tslFile.Text = "File";
            // 
            // tslEdit
            // 
            this.tslEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiText,
            this.tsmiFont,
            this.tsmiOptions});
            this.tslEdit.Name = "tslEdit";
            this.tslEdit.Size = new System.Drawing.Size(40, 22);
            this.tslEdit.Text = "Edit";
            // 
            // tslView
            // 
            this.tslView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMessage});
            this.tslView.Name = "tslView";
            this.tslView.Size = new System.Drawing.Size(45, 22);
            this.tslView.Text = "View";
            // 
            // tslHelp
            // 
            this.tslHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tslHelp.Name = "tslHelp";
            this.tslHelp.Size = new System.Drawing.Size(45, 22);
            this.tslHelp.Text = "Help";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpen.Text = "Open";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(180, 22);
            this.tsmiSave.Text = "Save";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            // 
            // tsmiText
            // 
            this.tsmiText.Name = "tsmiText";
            this.tsmiText.Size = new System.Drawing.Size(180, 22);
            this.tsmiText.Text = "Text";
            this.tsmiText.Click += new System.EventHandler(this.tsmiText_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(180, 22);
            this.tsmiFont.Text = "Font";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(180, 22);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiMessage
            // 
            this.tsmiMessage.Name = "tsmiMessage";
            this.tsmiMessage.Size = new System.Drawing.Size(180, 22);
            this.tsmiMessage.Text = "Message";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "About";
            // 
            // gbRunProgram
            // 
            this.gbRunProgram.Controls.Add(this.btnRunProgram);
            this.gbRunProgram.Controls.Add(this.cmbRunProgram);
            this.gbRunProgram.Location = new System.Drawing.Point(12, 45);
            this.gbRunProgram.Name = "gbRunProgram";
            this.gbRunProgram.Size = new System.Drawing.Size(319, 132);
            this.gbRunProgram.TabIndex = 1;
            this.gbRunProgram.TabStop = false;
            this.gbRunProgram.Text = "Run a program";
            // 
            // cmbRunProgram
            // 
            this.cmbRunProgram.FormattingEnabled = true;
            this.cmbRunProgram.Items.AddRange(new object[] {
            "Notepad",
            "Paint"});
            this.cmbRunProgram.Location = new System.Drawing.Point(6, 55);
            this.cmbRunProgram.Name = "cmbRunProgram";
            this.cmbRunProgram.Size = new System.Drawing.Size(182, 21);
            this.cmbRunProgram.TabIndex = 0;
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Location = new System.Drawing.Point(215, 55);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(89, 21);
            this.btnRunProgram.TabIndex = 1;
            this.btnRunProgram.Text = "Run program";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // chbShowProgramAction
            // 
            this.chbShowProgramAction.AutoSize = true;
            this.chbShowProgramAction.Location = new System.Drawing.Point(18, 207);
            this.chbShowProgramAction.Name = "chbShowProgramAction";
            this.chbShowProgramAction.Size = new System.Drawing.Size(126, 17);
            this.chbShowProgramAction.TabIndex = 2;
            this.chbShowProgramAction.Text = "Show program action";
            this.chbShowProgramAction.UseVisualStyleBackColor = true;
            this.chbShowProgramAction.CheckedChanged += new System.EventHandler(this.chbShowProgramAction_CheckedChanged);
            // 
            // gbProgramControl
            // 
            this.gbProgramControl.Controls.Add(this.btnClear);
            this.gbProgramControl.Controls.Add(this.txtbProgramDescription);
            this.gbProgramControl.Controls.Add(this.lblProgramDescription);
            this.gbProgramControl.Controls.Add(this.txtbProgramName);
            this.gbProgramControl.Controls.Add(this.lblProgramName);
            this.gbProgramControl.Location = new System.Drawing.Point(13, 250);
            this.gbProgramControl.Name = "gbProgramControl";
            this.gbProgramControl.Size = new System.Drawing.Size(318, 188);
            this.gbProgramControl.TabIndex = 3;
            this.gbProgramControl.TabStop = false;
            this.gbProgramControl.Text = "Program control";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(7, 35);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(78, 13);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Program name:";
            // 
            // txtbProgramName
            // 
            this.txtbProgramName.Location = new System.Drawing.Point(10, 52);
            this.txtbProgramName.Name = "txtbProgramName";
            this.txtbProgramName.Size = new System.Drawing.Size(177, 20);
            this.txtbProgramName.TabIndex = 1;
            // 
            // txtbProgramDescription
            // 
            this.txtbProgramDescription.Location = new System.Drawing.Point(10, 105);
            this.txtbProgramDescription.Multiline = true;
            this.txtbProgramDescription.Name = "txtbProgramDescription";
            this.txtbProgramDescription.Size = new System.Drawing.Size(177, 77);
            this.txtbProgramDescription.TabIndex = 3;
            // 
            // lblProgramDescription
            // 
            this.lblProgramDescription.AutoSize = true;
            this.lblProgramDescription.Location = new System.Drawing.Point(7, 88);
            this.lblProgramDescription.Name = "lblProgramDescription";
            this.lblProgramDescription.Size = new System.Drawing.Size(103, 13);
            this.lblProgramDescription.TabIndex = 2;
            this.lblProgramDescription.Text = "Program description:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(214, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 20);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.gbProgramControl);
            this.Controls.Add(this.chbShowProgramAction);
            this.Controls.Add(this.gbRunProgram);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbRunProgram.ResumeLayout(false);
            this.gbProgramControl.ResumeLayout(false);
            this.gbProgramControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tslFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripDropDownButton tslEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiText;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripDropDownButton tslView;
        private System.Windows.Forms.ToolStripMenuItem tsmiMessage;
        private System.Windows.Forms.ToolStripDropDownButton tslHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.GroupBox gbRunProgram;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.ComboBox cmbRunProgram;
        private System.Windows.Forms.CheckBox chbShowProgramAction;
        private System.Windows.Forms.GroupBox gbProgramControl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtbProgramDescription;
        private System.Windows.Forms.Label lblProgramDescription;
        private System.Windows.Forms.TextBox txtbProgramName;
        private System.Windows.Forms.Label lblProgramName;
    }
}

