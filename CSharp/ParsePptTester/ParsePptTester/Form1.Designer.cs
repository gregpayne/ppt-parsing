namespace ParsePptTester
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
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSlidecount = new System.Windows.Forms.Button();
            this.numSlideCount = new System.Windows.Forms.NumericUpDown();
            this.bSlideText = new System.Windows.Forms.Button();
            this.tbSlideText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSlideCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVersion
            // 
            this.tbVersion.Enabled = false;
            this.tbVersion.Location = new System.Drawing.Point(-1, 430);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(612, 20);
            this.tbVersion.TabIndex = 1;
            this.tbVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(114, 12);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(462, 20);
            this.tbPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PowerPoint path";
            // 
            // bSlidecount
            // 
            this.bSlidecount.Location = new System.Drawing.Point(21, 71);
            this.bSlidecount.Name = "bSlidecount";
            this.bSlidecount.Size = new System.Drawing.Size(112, 23);
            this.bSlidecount.TabIndex = 4;
            this.bSlidecount.Text = "Get Slide Count";
            this.bSlidecount.UseVisualStyleBackColor = true;
            this.bSlidecount.Click += new System.EventHandler(this.bSlidecount_Click);
            // 
            // numSlideCount
            // 
            this.numSlideCount.Enabled = false;
            this.numSlideCount.Location = new System.Drawing.Point(139, 74);
            this.numSlideCount.Name = "numSlideCount";
            this.numSlideCount.Size = new System.Drawing.Size(53, 20);
            this.numSlideCount.TabIndex = 5;
            this.numSlideCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bSlideText
            // 
            this.bSlideText.Location = new System.Drawing.Point(21, 114);
            this.bSlideText.Name = "bSlideText";
            this.bSlideText.Size = new System.Drawing.Size(112, 23);
            this.bSlideText.TabIndex = 6;
            this.bSlideText.Text = "Get Slide Text";
            this.bSlideText.UseVisualStyleBackColor = true;
            this.bSlideText.Click += new System.EventHandler(this.bSlideText_Click);
            // 
            // tbSlideText
            // 
            this.tbSlideText.Location = new System.Drawing.Point(21, 143);
            this.tbSlideText.Multiline = true;
            this.tbSlideText.Name = "tbSlideText";
            this.tbSlideText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSlideText.Size = new System.Drawing.Size(555, 281);
            this.tbSlideText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.tbSlideText);
            this.Controls.Add(this.bSlideText);
            this.Controls.Add(this.numSlideCount);
            this.Controls.Add(this.bSlidecount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbVersion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSlideCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSlidecount;
        private System.Windows.Forms.NumericUpDown numSlideCount;
        private System.Windows.Forms.Button bSlideText;
        private System.Windows.Forms.TextBox tbSlideText;
    }
}

