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
            this.connectToDatabase = new System.Windows.Forms.Button();
            this.tables = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // connectToDatabase
            // 
            this.connectToDatabase.Location = new System.Drawing.Point(13, 13);
            this.connectToDatabase.Name = "connectToDatabase";
            this.connectToDatabase.Size = new System.Drawing.Size(149, 23);
            this.connectToDatabase.TabIndex = 0;
            this.connectToDatabase.Text = "Connect to Database";
            this.connectToDatabase.UseVisualStyleBackColor = true;
            this.connectToDatabase.Click += new System.EventHandler(this.connectToDatabase_Click);
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(13, 43);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(380, 214);
            this.tables.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 394);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.connectToDatabase);
            this.Name = "Form1";
            this.Text = "UI for the EntityFramework Reverse POCO Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectToDatabase;
        private System.Windows.Forms.CheckedListBox tables;
    }
}

