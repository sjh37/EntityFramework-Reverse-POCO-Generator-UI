namespace EntityFramework_RPG_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectToDatabase = new System.Windows.Forms.Button();
            this.tables = new System.Windows.Forms.CheckedListBox();
            this.regex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAll = new System.Windows.Forms.LinkLabel();
            this.selectNone = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // connectToDatabase
            // 
            this.connectToDatabase.Location = new System.Drawing.Point(13, 13);
            this.connectToDatabase.Name = "connectToDatabase";
            this.connectToDatabase.Size = new System.Drawing.Size(149, 23);
            this.connectToDatabase.TabIndex = 0;
            this.connectToDatabase.Text = "&Connect to Database";
            this.connectToDatabase.UseVisualStyleBackColor = true;
            this.connectToDatabase.Click += new System.EventHandler(this.connectToDatabase_Click);
            // 
            // tables
            // 
            this.tables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tables.CheckOnClick = true;
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(13, 43);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(469, 289);
            this.tables.TabIndex = 3;
            this.tables.SelectedIndexChanged += new System.EventHandler(this.tables_SelectedIndexChanged);
            // 
            // regex
            // 
            this.regex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regex.CausesValidation = false;
            this.regex.Location = new System.Drawing.Point(13, 362);
            this.regex.MaxLength = 65535;
            this.regex.Name = "regex";
            this.regex.ReadOnly = true;
            this.regex.Size = new System.Drawing.Size(469, 20);
            this.regex.TabIndex = 4;
            this.regex.Text = "TableFilterInclude = null;";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regex (auto copied to clipboard)";
            // 
            // selectAll
            // 
            this.selectAll.AutoSize = true;
            this.selectAll.Location = new System.Drawing.Point(359, 27);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(51, 13);
            this.selectAll.TabIndex = 1;
            this.selectAll.TabStop = true;
            this.selectAll.Text = "Select All";
            this.selectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectAll_LinkClicked);
            // 
            // selectNone
            // 
            this.selectNone.AutoSize = true;
            this.selectNone.Location = new System.Drawing.Point(416, 27);
            this.selectNone.Name = "selectNone";
            this.selectNone.Size = new System.Drawing.Size(66, 13);
            this.selectNone.TabIndex = 2;
            this.selectNone.TabStop = true;
            this.selectNone.Text = "Select None";
            this.selectNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectNone_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 394);
            this.Controls.Add(this.selectNone);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regex);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.connectToDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UI for the EntityFramework Reverse POCO Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToDatabase;
        private System.Windows.Forms.CheckedListBox tables;
        private System.Windows.Forms.TextBox regex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel selectAll;
        private System.Windows.Forms.LinkLabel selectNone;
    }
}

