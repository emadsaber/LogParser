namespace ESH.Log.Parser.UI
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSourceFileBrowse = new System.Windows.Forms.Button();
            this.btnClearSourceFile = new System.Windows.Forms.Button();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.picIsValidSouceFilePath = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRequiredTypeTrace = new System.Windows.Forms.CheckBox();
            this.chkRequiredTypeInfo = new System.Windows.Forms.CheckBox();
            this.chkRequiredTypeWarning = new System.Windows.Forms.CheckBox();
            this.chkRequiredTypeError = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTypeOptionsAllInOneFile = new System.Windows.Forms.RadioButton();
            this.radTypeOptionsEachTypeInSeparateFile = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radLogRecordDuplicationIncludeDuplicatedRecords = new System.Windows.Forms.RadioButton();
            this.radLogRecordDuplicationHideDuplicatedRecords = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBrowseTargetDirectory = new System.Windows.Forms.Button();
            this.btnClearTargetDirectory = new System.Windows.Forms.Button();
            this.txtTargetDirectoryPath = new System.Windows.Forms.TextBox();
            this.picIsTargetDirectoryValid = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExitTool = new System.Windows.Forms.Button();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnStartProcessing = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsValidSouceFilePath)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsTargetDirectoryValid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picIsValidSouceFilePath);
            this.groupBox1.Controls.Add(this.txtSourceFilePath);
            this.groupBox1.Controls.Add(this.btnClearSourceFile);
            this.groupBox1.Controls.Add(this.btnSourceFileBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source file path";
            // 
            // btnSourceFileBrowse
            // 
            this.btnSourceFileBrowse.Location = new System.Drawing.Point(509, 17);
            this.btnSourceFileBrowse.Name = "btnSourceFileBrowse";
            this.btnSourceFileBrowse.Size = new System.Drawing.Size(45, 23);
            this.btnSourceFileBrowse.TabIndex = 0;
            this.btnSourceFileBrowse.Text = "...";
            this.btnSourceFileBrowse.UseVisualStyleBackColor = true;
            // 
            // btnClearSourceFile
            // 
            this.btnClearSourceFile.Location = new System.Drawing.Point(560, 17);
            this.btnClearSourceFile.Name = "btnClearSourceFile";
            this.btnClearSourceFile.Size = new System.Drawing.Size(45, 23);
            this.btnClearSourceFile.TabIndex = 0;
            this.btnClearSourceFile.Text = "Clear";
            this.btnClearSourceFile.UseVisualStyleBackColor = true;
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.Location = new System.Drawing.Point(6, 19);
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.Size = new System.Drawing.Size(497, 20);
            this.txtSourceFilePath.TabIndex = 1;
            // 
            // picIsValidSouceFilePath
            // 
            this.picIsValidSouceFilePath.Location = new System.Drawing.Point(612, 17);
            this.picIsValidSouceFilePath.Name = "picIsValidSouceFilePath";
            this.picIsValidSouceFilePath.Size = new System.Drawing.Size(29, 23);
            this.picIsValidSouceFilePath.TabIndex = 2;
            this.picIsValidSouceFilePath.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkRequiredTypeError);
            this.groupBox3.Controls.Add(this.chkRequiredTypeWarning);
            this.groupBox3.Controls.Add(this.chkRequiredTypeInfo);
            this.groupBox3.Controls.Add(this.chkRequiredTypeTrace);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 120);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Required Type";
            // 
            // chkRequiredTypeTrace
            // 
            this.chkRequiredTypeTrace.AutoSize = true;
            this.chkRequiredTypeTrace.Location = new System.Drawing.Point(7, 25);
            this.chkRequiredTypeTrace.Name = "chkRequiredTypeTrace";
            this.chkRequiredTypeTrace.Size = new System.Drawing.Size(53, 17);
            this.chkRequiredTypeTrace.TabIndex = 0;
            this.chkRequiredTypeTrace.Text = "Trace";
            this.chkRequiredTypeTrace.UseVisualStyleBackColor = true;
            // 
            // chkRequiredTypeInfo
            // 
            this.chkRequiredTypeInfo.AutoSize = true;
            this.chkRequiredTypeInfo.Location = new System.Drawing.Point(7, 48);
            this.chkRequiredTypeInfo.Name = "chkRequiredTypeInfo";
            this.chkRequiredTypeInfo.Size = new System.Drawing.Size(46, 17);
            this.chkRequiredTypeInfo.TabIndex = 0;
            this.chkRequiredTypeInfo.Text = "Info";
            this.chkRequiredTypeInfo.UseVisualStyleBackColor = true;
            // 
            // chkRequiredTypeWarning
            // 
            this.chkRequiredTypeWarning.AutoSize = true;
            this.chkRequiredTypeWarning.Location = new System.Drawing.Point(7, 71);
            this.chkRequiredTypeWarning.Name = "chkRequiredTypeWarning";
            this.chkRequiredTypeWarning.Size = new System.Drawing.Size(66, 17);
            this.chkRequiredTypeWarning.TabIndex = 0;
            this.chkRequiredTypeWarning.Text = "Warning";
            this.chkRequiredTypeWarning.UseVisualStyleBackColor = true;
            // 
            // chkRequiredTypeError
            // 
            this.chkRequiredTypeError.AutoSize = true;
            this.chkRequiredTypeError.Location = new System.Drawing.Point(7, 94);
            this.chkRequiredTypeError.Name = "chkRequiredTypeError";
            this.chkRequiredTypeError.Size = new System.Drawing.Size(50, 17);
            this.chkRequiredTypeError.TabIndex = 0;
            this.chkRequiredTypeError.Text = "Error";
            this.chkRequiredTypeError.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTypeOptionsEachTypeInSeparateFile);
            this.groupBox4.Controls.Add(this.radTypeOptionsAllInOneFile);
            this.groupBox4.Location = new System.Drawing.Point(139, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 120);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Types Options";
            // 
            // radTypeOptionsAllInOneFile
            // 
            this.radTypeOptionsAllInOneFile.AutoSize = true;
            this.radTypeOptionsAllInOneFile.Location = new System.Drawing.Point(6, 38);
            this.radTypeOptionsAllInOneFile.Name = "radTypeOptionsAllInOneFile";
            this.radTypeOptionsAllInOneFile.Size = new System.Drawing.Size(115, 17);
            this.radTypeOptionsAllInOneFile.TabIndex = 0;
            this.radTypeOptionsAllInOneFile.Text = "All types in one file";
            this.radTypeOptionsAllInOneFile.UseVisualStyleBackColor = true;
            // 
            // radTypeOptionsEachTypeInSeparateFile
            // 
            this.radTypeOptionsEachTypeInSeparateFile.AutoSize = true;
            this.radTypeOptionsEachTypeInSeparateFile.Checked = true;
            this.radTypeOptionsEachTypeInSeparateFile.Location = new System.Drawing.Point(6, 61);
            this.radTypeOptionsEachTypeInSeparateFile.Name = "radTypeOptionsEachTypeInSeparateFile";
            this.radTypeOptionsEachTypeInSeparateFile.Size = new System.Drawing.Size(147, 17);
            this.radTypeOptionsEachTypeInSeparateFile.TabIndex = 0;
            this.radTypeOptionsEachTypeInSeparateFile.TabStop = true;
            this.radTypeOptionsEachTypeInSeparateFile.Text = "Each type in separate file";
            this.radTypeOptionsEachTypeInSeparateFile.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radLogRecordDuplicationHideDuplicatedRecords);
            this.groupBox5.Controls.Add(this.radLogRecordDuplicationIncludeDuplicatedRecords);
            this.groupBox5.Location = new System.Drawing.Point(307, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 120);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log record duplication";
            // 
            // radLogRecordDuplicationIncludeDuplicatedRecords
            // 
            this.radLogRecordDuplicationIncludeDuplicatedRecords.AutoSize = true;
            this.radLogRecordDuplicationIncludeDuplicatedRecords.Location = new System.Drawing.Point(6, 38);
            this.radLogRecordDuplicationIncludeDuplicatedRecords.Name = "radLogRecordDuplicationIncludeDuplicatedRecords";
            this.radLogRecordDuplicationIncludeDuplicatedRecords.Size = new System.Drawing.Size(151, 17);
            this.radLogRecordDuplicationIncludeDuplicatedRecords.TabIndex = 0;
            this.radLogRecordDuplicationIncludeDuplicatedRecords.Text = "Include duplicated records";
            this.radLogRecordDuplicationIncludeDuplicatedRecords.UseVisualStyleBackColor = true;
            // 
            // radLogRecordDuplicationHideDuplicatedRecords
            // 
            this.radLogRecordDuplicationHideDuplicatedRecords.AutoSize = true;
            this.radLogRecordDuplicationHideDuplicatedRecords.Checked = true;
            this.radLogRecordDuplicationHideDuplicatedRecords.Location = new System.Drawing.Point(6, 61);
            this.radLogRecordDuplicationHideDuplicatedRecords.Name = "radLogRecordDuplicationHideDuplicatedRecords";
            this.radLogRecordDuplicationHideDuplicatedRecords.Size = new System.Drawing.Size(180, 17);
            this.radLogRecordDuplicationHideDuplicatedRecords.TabIndex = 0;
            this.radLogRecordDuplicationHideDuplicatedRecords.TabStop = true;
            this.radLogRecordDuplicationHideDuplicatedRecords.Text = "Hide duplicated records (Slower)";
            this.radLogRecordDuplicationHideDuplicatedRecords.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picIsTargetDirectoryValid);
            this.groupBox6.Controls.Add(this.txtTargetDirectoryPath);
            this.groupBox6.Controls.Add(this.btnClearTargetDirectory);
            this.groupBox6.Controls.Add(this.btnBrowseTargetDirectory);
            this.groupBox6.Location = new System.Drawing.Point(6, 141);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(652, 48);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Target directory";
            // 
            // btnBrowseTargetDirectory
            // 
            this.btnBrowseTargetDirectory.Location = new System.Drawing.Point(509, 17);
            this.btnBrowseTargetDirectory.Name = "btnBrowseTargetDirectory";
            this.btnBrowseTargetDirectory.Size = new System.Drawing.Size(45, 23);
            this.btnBrowseTargetDirectory.TabIndex = 0;
            this.btnBrowseTargetDirectory.Text = "...";
            this.btnBrowseTargetDirectory.UseVisualStyleBackColor = true;
            // 
            // btnClearTargetDirectory
            // 
            this.btnClearTargetDirectory.Location = new System.Drawing.Point(560, 17);
            this.btnClearTargetDirectory.Name = "btnClearTargetDirectory";
            this.btnClearTargetDirectory.Size = new System.Drawing.Size(45, 23);
            this.btnClearTargetDirectory.TabIndex = 0;
            this.btnClearTargetDirectory.Text = "Clear";
            this.btnClearTargetDirectory.UseVisualStyleBackColor = true;
            // 
            // txtTargetDirectoryPath
            // 
            this.txtTargetDirectoryPath.Location = new System.Drawing.Point(6, 19);
            this.txtTargetDirectoryPath.Name = "txtTargetDirectoryPath";
            this.txtTargetDirectoryPath.Size = new System.Drawing.Size(491, 20);
            this.txtTargetDirectoryPath.TabIndex = 1;
            // 
            // picIsTargetDirectoryValid
            // 
            this.picIsTargetDirectoryValid.Location = new System.Drawing.Point(612, 17);
            this.picIsTargetDirectoryValid.Name = "picIsTargetDirectoryValid";
            this.picIsTargetDirectoryValid.Size = new System.Drawing.Size(29, 23);
            this.picIsTargetDirectoryValid.TabIndex = 2;
            this.picIsTargetDirectoryValid.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Options";
            // 
            // btnExitTool
            // 
            this.btnExitTool.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnExitTool.ForeColor = System.Drawing.Color.Red;
            this.btnExitTool.Location = new System.Drawing.Point(426, 289);
            this.btnExitTool.Name = "btnExitTool";
            this.btnExitTool.Size = new System.Drawing.Size(105, 30);
            this.btnExitTool.TabIndex = 2;
            this.btnExitTool.Text = "Exit tool";
            this.btnExitTool.UseVisualStyleBackColor = true;
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancelOperation.ForeColor = System.Drawing.Color.Red;
            this.btnCancelOperation.Location = new System.Drawing.Point(141, 289);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(111, 30);
            this.btnCancelOperation.TabIndex = 3;
            this.btnCancelOperation.Text = "Cancel Operation";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartProcessing.Location = new System.Drawing.Point(258, 281);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(162, 47);
            this.btnStartProcessing.TabIndex = 4;
            this.btnStartProcessing.Text = "Start Processing";
            this.btnStartProcessing.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtSummary);
            this.groupBox7.Location = new System.Drawing.Point(498, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(158, 120);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Summary";
            // 
            // txtSummary
            // 
            this.txtSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSummary.Location = new System.Drawing.Point(3, 16);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(152, 101);
            this.txtSummary.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 334);
            this.Controls.Add(this.btnExitTool);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Log Parser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsValidSouceFilePath)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsTargetDirectoryValid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSourceFilePath;
        private System.Windows.Forms.Button btnClearSourceFile;
        private System.Windows.Forms.Button btnSourceFileBrowse;
        private System.Windows.Forms.PictureBox picIsValidSouceFilePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkRequiredTypeError;
        private System.Windows.Forms.CheckBox chkRequiredTypeWarning;
        private System.Windows.Forms.CheckBox chkRequiredTypeInfo;
        private System.Windows.Forms.CheckBox chkRequiredTypeTrace;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTypeOptionsEachTypeInSeparateFile;
        private System.Windows.Forms.RadioButton radTypeOptionsAllInOneFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radLogRecordDuplicationHideDuplicatedRecords;
        private System.Windows.Forms.RadioButton radLogRecordDuplicationIncludeDuplicatedRecords;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox picIsTargetDirectoryValid;
        private System.Windows.Forms.TextBox txtTargetDirectoryPath;
        private System.Windows.Forms.Button btnClearTargetDirectory;
        private System.Windows.Forms.Button btnBrowseTargetDirectory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExitTool;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnStartProcessing;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSummary;
    }
}

