namespace Finger_Print_Recognition
{
    partial class Finger_Print_Comparison
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
            this.gbxQueryFingerprint = new System.Windows.Forms.GroupBox();
            this.pnlQueryImage = new System.Windows.Forms.Panel();
            this.pbxQueryImg = new System.Windows.Forms.PictureBox();
            this.pnlQueryButtons = new System.Windows.Forms.Panel();
            this.btnLoadQueryImg = new System.Windows.Forms.Button();
            this.pnlTemplateImage = new System.Windows.Forms.Panel();
            this.pbxTemplateImg = new System.Windows.Forms.PictureBox();
            this.pnlTemplateButtons = new System.Windows.Forms.Panel();
            this.btnLoadTemplateImg = new System.Windows.Forms.Button();
            this.gbxTemplateFingerprint = new System.Windows.Forms.GroupBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxQueryFingerprint.SuspendLayout();
            this.pnlQueryImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueryImg)).BeginInit();
            this.pnlQueryButtons.SuspendLayout();
            this.pnlTemplateImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTemplateImg)).BeginInit();
            this.pnlTemplateButtons.SuspendLayout();
            this.gbxTemplateFingerprint.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQueryFingerprint
            // 
            this.gbxQueryFingerprint.Controls.Add(this.pnlQueryImage);
            this.gbxQueryFingerprint.Controls.Add(this.pnlQueryButtons);
            this.gbxQueryFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQueryFingerprint.ForeColor = System.Drawing.Color.Tomato;
            this.gbxQueryFingerprint.Location = new System.Drawing.Point(12, 5);
            this.gbxQueryFingerprint.Name = "gbxQueryFingerprint";
            this.gbxQueryFingerprint.Size = new System.Drawing.Size(371, 424);
            this.gbxQueryFingerprint.TabIndex = 0;
            this.gbxQueryFingerprint.TabStop = false;
            this.gbxQueryFingerprint.Text = "Query Fingerprint";
            // 
            // pnlQueryImage
            // 
            this.pnlQueryImage.AutoScroll = true;
            this.pnlQueryImage.Controls.Add(this.pbxQueryImg);
            this.pnlQueryImage.Location = new System.Drawing.Point(3, 20);
            this.pnlQueryImage.Name = "pnlQueryImage";
            this.pnlQueryImage.Size = new System.Drawing.Size(293, 325);
            this.pnlQueryImage.TabIndex = 0;
            // 
            // pbxQueryImg
            // 
            this.pbxQueryImg.Location = new System.Drawing.Point(3, 3);
            this.pbxQueryImg.Name = "pbxQueryImg";
            this.pbxQueryImg.Size = new System.Drawing.Size(275, 307);
            this.pbxQueryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxQueryImg.TabIndex = 0;
            this.pbxQueryImg.TabStop = false;
            // 
            // pnlQueryButtons
            // 
            this.pnlQueryButtons.Controls.Add(this.btnLoadQueryImg);
            this.pnlQueryButtons.Location = new System.Drawing.Point(3, 359);
            this.pnlQueryButtons.Name = "pnlQueryButtons";
            this.pnlQueryButtons.Size = new System.Drawing.Size(362, 48);
            this.pnlQueryButtons.TabIndex = 1;
            // 
            // btnLoadQueryImg
            // 
            this.btnLoadQueryImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadQueryImg.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadQueryImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadQueryImg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadQueryImg.Location = new System.Drawing.Point(182, 11);
            this.btnLoadQueryImg.Name = "btnLoadQueryImg";
            this.btnLoadQueryImg.Size = new System.Drawing.Size(96, 26);
            this.btnLoadQueryImg.TabIndex = 0;
            this.btnLoadQueryImg.Text = "Load Image";
            this.btnLoadQueryImg.UseVisualStyleBackColor = false;
            this.btnLoadQueryImg.Click += new System.EventHandler(this.btnLoadQueryImg_Click);
            // 
            // pnlTemplateImage
            // 
            this.pnlTemplateImage.AutoScroll = true;
            this.pnlTemplateImage.Controls.Add(this.pbxTemplateImg);
            this.pnlTemplateImage.Location = new System.Drawing.Point(3, 20);
            this.pnlTemplateImage.Name = "pnlTemplateImage";
            this.pnlTemplateImage.Size = new System.Drawing.Size(293, 325);
            this.pnlTemplateImage.TabIndex = 2;
            // 
            // pbxTemplateImg
            // 
            this.pbxTemplateImg.Location = new System.Drawing.Point(4, 3);
            this.pbxTemplateImg.Name = "pbxTemplateImg";
            this.pbxTemplateImg.Size = new System.Drawing.Size(275, 307);
            this.pbxTemplateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTemplateImg.TabIndex = 1;
            this.pbxTemplateImg.TabStop = false;
            // 
            // pnlTemplateButtons
            // 
            this.pnlTemplateButtons.Controls.Add(this.btnLoadTemplateImg);
            this.pnlTemplateButtons.Location = new System.Drawing.Point(3, 359);
            this.pnlTemplateButtons.Name = "pnlTemplateButtons";
            this.pnlTemplateButtons.Size = new System.Drawing.Size(362, 48);
            this.pnlTemplateButtons.TabIndex = 3;
            // 
            // btnLoadTemplateImg
            // 
            this.btnLoadTemplateImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTemplateImg.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadTemplateImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTemplateImg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadTemplateImg.Location = new System.Drawing.Point(183, 11);
            this.btnLoadTemplateImg.Name = "btnLoadTemplateImg";
            this.btnLoadTemplateImg.Size = new System.Drawing.Size(96, 26);
            this.btnLoadTemplateImg.TabIndex = 2;
            this.btnLoadTemplateImg.Text = "Load Image";
            this.btnLoadTemplateImg.UseVisualStyleBackColor = false;
            this.btnLoadTemplateImg.Click += new System.EventHandler(this.btnLoadTemplateImg_Click);
            // 
            // gbxTemplateFingerprint
            // 
            this.gbxTemplateFingerprint.Controls.Add(this.pnlTemplateImage);
            this.gbxTemplateFingerprint.Controls.Add(this.pnlTemplateButtons);
            this.gbxTemplateFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTemplateFingerprint.ForeColor = System.Drawing.Color.Tomato;
            this.gbxTemplateFingerprint.Location = new System.Drawing.Point(405, 5);
            this.gbxTemplateFingerprint.Name = "gbxTemplateFingerprint";
            this.gbxTemplateFingerprint.Size = new System.Drawing.Size(371, 424);
            this.gbxTemplateFingerprint.TabIndex = 1;
            this.gbxTemplateFingerprint.TabStop = false;
            this.gbxTemplateFingerprint.Text = "Template Fingerprint";
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatch.BackColor = System.Drawing.Color.Tomato;
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.ForeColor = System.Drawing.Color.MistyRose;
            this.btnMatch.Location = new System.Drawing.Point(354, 13);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 29);
            this.btnMatch.TabIndex = 6;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.button1);
            this.pnlBottom.Controls.Add(this.btnMatch);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 437);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(787, 55);
            this.pnlBottom.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.tif;*.bmp;*.jpg";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(686, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Extract >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Finger_Print_Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(787, 492);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.gbxTemplateFingerprint);
            this.Controls.Add(this.gbxQueryFingerprint);
            this.Name = "Finger_Print_Comparison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finger Print Comparison";
            this.Load += new System.EventHandler(this.Finger_Print_Comparison_Load);
            this.gbxQueryFingerprint.ResumeLayout(false);
            this.pnlQueryImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQueryImg)).EndInit();
            this.pnlQueryButtons.ResumeLayout(false);
            this.pnlTemplateImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTemplateImg)).EndInit();
            this.pnlTemplateButtons.ResumeLayout(false);
            this.gbxTemplateFingerprint.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxQueryFingerprint;
        private System.Windows.Forms.Panel pnlQueryImage;
        private System.Windows.Forms.PictureBox pbxQueryImg;
        private System.Windows.Forms.Panel pnlQueryButtons;
        private System.Windows.Forms.Button btnLoadQueryImg;
        private System.Windows.Forms.Panel pnlTemplateImage;
        private System.Windows.Forms.PictureBox pbxTemplateImg;
        private System.Windows.Forms.Panel pnlTemplateButtons;
        private System.Windows.Forms.Button btnLoadTemplateImg;
        private System.Windows.Forms.GroupBox gbxTemplateFingerprint;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}