namespace PTGoogleSearch
{
    partial class GoogleForm
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
            this.txtSearchTerms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdExpand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDomain = new System.Windows.Forms.CheckBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.optMap = new System.Windows.Forms.RadioButton();
            this.optTimeline = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchTerms
            // 
            this.txtSearchTerms.Location = new System.Drawing.Point(12, 25);
            this.txtSearchTerms.Name = "txtSearchTerms";
            this.txtSearchTerms.Size = new System.Drawing.Size(268, 20);
            this.txtSearchTerms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Search Terms";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(96, 51);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "&Go";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(177, 51);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdExpand
            // 
            this.cmdExpand.Location = new System.Drawing.Point(258, 51);
            this.cmdExpand.Name = "cmdExpand";
            this.cmdExpand.Size = new System.Drawing.Size(22, 23);
            this.cmdExpand.TabIndex = 4;
            this.cmdExpand.Text = "V";
            this.cmdExpand.UseVisualStyleBackColor = true;
            this.cmdExpand.Click += new System.EventHandler(this.cmdExpand_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDomain);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.optMap);
            this.groupBox1.Controls.Add(this.optTimeline);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Search";
            // 
            // chkDomain
            // 
            this.chkDomain.AutoSize = true;
            this.chkDomain.Location = new System.Drawing.Point(7, 67);
            this.chkDomain.Name = "chkDomain";
            this.chkDomain.Size = new System.Drawing.Size(113, 17);
            this.chkDomain.TabIndex = 3;
            this.chkDomain.Text = "Restrict to &Domain";
            this.chkDomain.UseVisualStyleBackColor = true;
            this.chkDomain.CheckedChanged += new System.EventHandler(this.chkDomain_CheckedChanged);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(120, 64);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(142, 20);
            this.txtDomain.TabIndex = 2;
            // 
            // optMap
            // 
            this.optMap.AutoSize = true;
            this.optMap.Location = new System.Drawing.Point(7, 43);
            this.optMap.Name = "optMap";
            this.optMap.Size = new System.Drawing.Size(76, 17);
            this.optMap.TabIndex = 1;
            this.optMap.TabStop = true;
            this.optMap.Text = "Show &Map";
            this.optMap.UseVisualStyleBackColor = true;
            // 
            // optTimeline
            // 
            this.optTimeline.AutoSize = true;
            this.optTimeline.Location = new System.Drawing.Point(7, 20);
            this.optTimeline.Name = "optTimeline";
            this.optTimeline.Size = new System.Drawing.Size(94, 17);
            this.optTimeline.TabIndex = 0;
            this.optTimeline.TabStop = true;
            this.optTimeline.Text = "Show &Timeline";
            this.optTimeline.UseVisualStyleBackColor = true;
            // 
            // GoogleForm
            // 
            this.AcceptButton = this.cmdSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(292, 179);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdExpand);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchTerms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoogleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Google";
            this.Load += new System.EventHandler(this.GoogleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdExpand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.RadioButton optMap;
        private System.Windows.Forms.RadioButton optTimeline;
        private System.Windows.Forms.CheckBox chkDomain;
    }
}