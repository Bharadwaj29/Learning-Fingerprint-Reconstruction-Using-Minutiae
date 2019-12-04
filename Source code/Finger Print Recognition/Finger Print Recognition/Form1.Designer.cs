namespace Finger_Print_Recognition
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxResources = new System.Windows.Forms.TextBox();
            this.btnFindResources = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblExperiment = new System.Windows.Forms.Label();
            this.cbxExperiment = new System.Windows.Forms.ComboBox();
            this.lblFeatureProvider = new System.Windows.Forms.Label();
            this.cbxFeatureProvider = new System.Windows.Forms.ComboBox();
            this.lblMatcher = new System.Windows.Forms.Label();
            this.cbxMatcher = new System.Windows.Forms.ComboBox();
            this.lblSkeletonImageExtractor = new System.Windows.Forms.Label();
            this.cbxSkeletonImageExtractor = new System.Windows.Forms.ComboBox();
            this.lblOrientationImageExtractor = new System.Windows.Forms.Label();
            this.cbxOrientationImageExtractor = new System.Windows.Forms.ComboBox();
            this.lblMinutiaExtractor = new System.Windows.Forms.Label();
            this.cbxMinutiaExtractor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblProgressValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(297, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "FingerPrint Comparison";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Resources";
            // 
            // tbxResources
            // 
            this.tbxResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResources.Location = new System.Drawing.Point(115, 52);
            this.tbxResources.Name = "tbxResources";
            this.tbxResources.Size = new System.Drawing.Size(469, 20);
            this.tbxResources.TabIndex = 18;
            // 
            // btnFindResources
            // 
            this.btnFindResources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindResources.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFindResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindResources.Location = new System.Drawing.Point(596, 49);
            this.btnFindResources.Name = "btnFindResources";
            this.btnFindResources.Size = new System.Drawing.Size(28, 23);
            this.btnFindResources.TabIndex = 17;
            this.btnFindResources.Text = "...";
            this.btnFindResources.UseVisualStyleBackColor = true;
            this.btnFindResources.Click += new System.EventHandler(this.btnFindResources_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\Fingerprints\\Resources\\FVC2004";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // lblExperiment
            // 
            this.lblExperiment.AutoSize = true;
            this.lblExperiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiment.Location = new System.Drawing.Point(56, 38);
            this.lblExperiment.Name = "lblExperiment";
            this.lblExperiment.Size = new System.Drawing.Size(131, 15);
            this.lblExperiment.TabIndex = 45;
            this.lblExperiment.Text = "Experiment Images";
            // 
            // cbxExperiment
            // 
            this.cbxExperiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExperiment.FormattingEnabled = true;
            this.cbxExperiment.Location = new System.Drawing.Point(198, 37);
            this.cbxExperiment.Name = "cbxExperiment";
            this.cbxExperiment.Size = new System.Drawing.Size(224, 21);
            this.cbxExperiment.Sorted = true;
            this.cbxExperiment.TabIndex = 44;
            this.cbxExperiment.SelectedIndexChanged += new System.EventHandler(this.cbxExperiment_SelectedIndexChanged);
            this.cbxExperiment.SelectedValueChanged += new System.EventHandler(this.cbxExperiment_SelectedValueChanged);
            // 
            // lblFeatureProvider
            // 
            this.lblFeatureProvider.AutoSize = true;
            this.lblFeatureProvider.Location = new System.Drawing.Point(143, 336);
            this.lblFeatureProvider.Name = "lblFeatureProvider";
            this.lblFeatureProvider.Size = new System.Drawing.Size(13, 13);
            this.lblFeatureProvider.TabIndex = 43;
            this.lblFeatureProvider.Text = "F";
            this.lblFeatureProvider.Visible = false;
            // 
            // cbxFeatureProvider
            // 
            this.cbxFeatureProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFeatureProvider.FormattingEnabled = true;
            this.cbxFeatureProvider.Location = new System.Drawing.Point(159, 333);
            this.cbxFeatureProvider.Name = "cbxFeatureProvider";
            this.cbxFeatureProvider.Size = new System.Drawing.Size(20, 21);
            this.cbxFeatureProvider.TabIndex = 42;
            this.cbxFeatureProvider.Visible = false;
            this.cbxFeatureProvider.SelectedValueChanged += new System.EventHandler(this.cbxFeatureProvider_SelectedValueChanged);
            // 
            // lblMatcher
            // 
            this.lblMatcher.AutoSize = true;
            this.lblMatcher.Location = new System.Drawing.Point(141, 314);
            this.lblMatcher.Name = "lblMatcher";
            this.lblMatcher.Size = new System.Drawing.Size(16, 13);
            this.lblMatcher.TabIndex = 41;
            this.lblMatcher.Text = "M";
            this.lblMatcher.Visible = false;
            // 
            // cbxMatcher
            // 
            this.cbxMatcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatcher.FormattingEnabled = true;
            this.cbxMatcher.Location = new System.Drawing.Point(159, 311);
            this.cbxMatcher.Name = "cbxMatcher";
            this.cbxMatcher.Size = new System.Drawing.Size(20, 21);
            this.cbxMatcher.TabIndex = 40;
            this.cbxMatcher.Visible = false;
            this.cbxMatcher.SelectedValueChanged += new System.EventHandler(this.cbxMatcher_SelectedValueChanged);
            // 
            // lblSkeletonImageExtractor
            // 
            this.lblSkeletonImageExtractor.AutoSize = true;
            this.lblSkeletonImageExtractor.Location = new System.Drawing.Point(138, 291);
            this.lblSkeletonImageExtractor.Name = "lblSkeletonImageExtractor";
            this.lblSkeletonImageExtractor.Size = new System.Drawing.Size(20, 13);
            this.lblSkeletonImageExtractor.TabIndex = 39;
            this.lblSkeletonImageExtractor.Text = "Sk";
            this.lblSkeletonImageExtractor.Visible = false;
            // 
            // cbxSkeletonImageExtractor
            // 
            this.cbxSkeletonImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkeletonImageExtractor.FormattingEnabled = true;
            this.cbxSkeletonImageExtractor.Location = new System.Drawing.Point(159, 288);
            this.cbxSkeletonImageExtractor.Name = "cbxSkeletonImageExtractor";
            this.cbxSkeletonImageExtractor.Size = new System.Drawing.Size(20, 21);
            this.cbxSkeletonImageExtractor.Sorted = true;
            this.cbxSkeletonImageExtractor.TabIndex = 38;
            this.cbxSkeletonImageExtractor.Visible = false;
            this.cbxSkeletonImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxSkeletonImageExtractor_SelectedValueChanged);
            // 
            // lblOrientationImageExtractor
            // 
            this.lblOrientationImageExtractor.AutoSize = true;
            this.lblOrientationImageExtractor.Location = new System.Drawing.Point(139, 269);
            this.lblOrientationImageExtractor.Name = "lblOrientationImageExtractor";
            this.lblOrientationImageExtractor.Size = new System.Drawing.Size(18, 13);
            this.lblOrientationImageExtractor.TabIndex = 37;
            this.lblOrientationImageExtractor.Text = "Or";
            this.lblOrientationImageExtractor.Visible = false;
            // 
            // cbxOrientationImageExtractor
            // 
            this.cbxOrientationImageExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientationImageExtractor.FormattingEnabled = true;
            this.cbxOrientationImageExtractor.Location = new System.Drawing.Point(159, 266);
            this.cbxOrientationImageExtractor.Name = "cbxOrientationImageExtractor";
            this.cbxOrientationImageExtractor.Size = new System.Drawing.Size(20, 21);
            this.cbxOrientationImageExtractor.Sorted = true;
            this.cbxOrientationImageExtractor.TabIndex = 36;
            this.cbxOrientationImageExtractor.Visible = false;
            this.cbxOrientationImageExtractor.SelectedValueChanged += new System.EventHandler(this.cbxOrientationImageExtractor_SelectedValueChanged);
            // 
            // lblMinutiaExtractor
            // 
            this.lblMinutiaExtractor.AutoSize = true;
            this.lblMinutiaExtractor.Location = new System.Drawing.Point(134, 251);
            this.lblMinutiaExtractor.Name = "lblMinutiaExtractor";
            this.lblMinutiaExtractor.Size = new System.Drawing.Size(24, 13);
            this.lblMinutiaExtractor.TabIndex = 35;
            this.lblMinutiaExtractor.Text = "Min";
            this.lblMinutiaExtractor.Visible = false;
            // 
            // cbxMinutiaExtractor
            // 
            this.cbxMinutiaExtractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutiaExtractor.FormattingEnabled = true;
            this.cbxMinutiaExtractor.Location = new System.Drawing.Point(159, 248);
            this.cbxMinutiaExtractor.Name = "cbxMinutiaExtractor";
            this.cbxMinutiaExtractor.Size = new System.Drawing.Size(20, 21);
            this.cbxMinutiaExtractor.Sorted = true;
            this.cbxMinutiaExtractor.TabIndex = 34;
            this.cbxMinutiaExtractor.Visible = false;
            this.cbxMinutiaExtractor.SelectedValueChanged += new System.EventHandler(this.cbxMinutiaExtractor_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnFindResources);
            this.groupBox1.Controls.Add(this.tbxResources);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(44, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 372);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblProgressValue);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.cbxExperiment);
            this.panel1.Controls.Add(this.lblExperiment);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(52, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 203);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(109, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 29);
            this.button2.TabIndex = 49;
            this.button2.Text = "Execute Experiment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblProgressValue
            // 
            this.lblProgressValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressValue.AutoSize = true;
            this.lblProgressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressValue.Location = new System.Drawing.Point(505, 111);
            this.lblProgressValue.Name = "lblProgressValue";
            this.lblProgressValue.Size = new System.Drawing.Size(23, 13);
            this.lblProgressValue.TabIndex = 48;
            this.lblProgressValue.Text = "0%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 15);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(77, 107);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(72, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 50);
            this.label1.TabIndex = 47;
            this.label1.Text = "Learning Fingerprint Reconstruction: From Minutiae to Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(747, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFeatureProvider);
            this.Controls.Add(this.cbxFeatureProvider);
            this.Controls.Add(this.lblMatcher);
            this.Controls.Add(this.cbxMatcher);
            this.Controls.Add(this.lblSkeletonImageExtractor);
            this.Controls.Add(this.cbxSkeletonImageExtractor);
            this.Controls.Add(this.lblOrientationImageExtractor);
            this.Controls.Add(this.cbxOrientationImageExtractor);
            this.Controls.Add(this.lblMinutiaExtractor);
            this.Controls.Add(this.cbxMinutiaExtractor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experiment All Finger Prints";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxResources;
        private System.Windows.Forms.Button btnFindResources;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblExperiment;
        private System.Windows.Forms.ComboBox cbxExperiment;
        private System.Windows.Forms.Label lblFeatureProvider;
        private System.Windows.Forms.ComboBox cbxFeatureProvider;
        private System.Windows.Forms.Label lblMatcher;
        private System.Windows.Forms.ComboBox cbxMatcher;
        private System.Windows.Forms.Label lblSkeletonImageExtractor;
        private System.Windows.Forms.ComboBox cbxSkeletonImageExtractor;
        private System.Windows.Forms.Label lblOrientationImageExtractor;
        private System.Windows.Forms.ComboBox cbxOrientationImageExtractor;
        private System.Windows.Forms.Label lblMinutiaExtractor;
        private System.Windows.Forms.ComboBox cbxMinutiaExtractor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProgressValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

