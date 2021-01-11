namespace FantasyNameGenerator
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
            this.usedNamesList = new System.Windows.Forms.ListBox();
            this.textBoxFirstN = new System.Windows.Forms.TextBox();
            this.textBoxLastN = new System.Windows.Forms.TextBox();
            this.checkBoxFirstN = new System.Windows.Forms.CheckBox();
            this.checkBoxLastN = new System.Windows.Forms.CheckBox();
            this.buttonDeleteN = new System.Windows.Forms.Button();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usedNamesList
            // 
            this.usedNamesList.ColumnWidth = 10;
            this.usedNamesList.FormattingEnabled = true;
            this.usedNamesList.Location = new System.Drawing.Point(246, 12);
            this.usedNamesList.Name = "usedNamesList";
            this.usedNamesList.Size = new System.Drawing.Size(120, 199);
            this.usedNamesList.TabIndex = 0;
            this.usedNamesList.SelectedIndexChanged += new System.EventHandler(this.usedNamesList_SelectedIndexChanged);
            // 
            // textBoxFirstN
            // 
            this.textBoxFirstN.Location = new System.Drawing.Point(12, 12);
            this.textBoxFirstN.Name = "textBoxFirstN";
            this.textBoxFirstN.ReadOnly = true;
            this.textBoxFirstN.Size = new System.Drawing.Size(142, 20);
            this.textBoxFirstN.TabIndex = 1;
            this.textBoxFirstN.TextChanged += new System.EventHandler(this.textBoxFirstN_TextChanged);
            // 
            // textBoxLastN
            // 
            this.textBoxLastN.Location = new System.Drawing.Point(12, 38);
            this.textBoxLastN.Name = "textBoxLastN";
            this.textBoxLastN.ReadOnly = true;
            this.textBoxLastN.Size = new System.Drawing.Size(142, 20);
            this.textBoxLastN.TabIndex = 2;
            this.textBoxLastN.TextChanged += new System.EventHandler(this.textBoxLastN_TextChanged);
            // 
            // checkBoxFirstN
            // 
            this.checkBoxFirstN.AutoSize = true;
            this.checkBoxFirstN.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxFirstN.Checked = true;
            this.checkBoxFirstN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstN.Location = new System.Drawing.Point(160, 15);
            this.checkBoxFirstN.Name = "checkBoxFirstN";
            this.checkBoxFirstN.Size = new System.Drawing.Size(74, 17);
            this.checkBoxFirstN.TabIndex = 3;
            this.checkBoxFirstN.Text = "First name";
            this.checkBoxFirstN.UseVisualStyleBackColor = false;
            this.checkBoxFirstN.CheckedChanged += new System.EventHandler(this.checkBoxFirstN_CheckedChanged);
            // 
            // checkBoxLastN
            // 
            this.checkBoxLastN.AutoSize = true;
            this.checkBoxLastN.Checked = true;
            this.checkBoxLastN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLastN.Location = new System.Drawing.Point(160, 41);
            this.checkBoxLastN.Name = "checkBoxLastN";
            this.checkBoxLastN.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLastN.TabIndex = 4;
            this.checkBoxLastN.Text = "Last name";
            this.checkBoxLastN.UseVisualStyleBackColor = true;
            this.checkBoxLastN.CheckedChanged += new System.EventHandler(this.checkBoxLastN_CheckedChanged);
            // 
            // buttonDeleteN
            // 
            this.buttonDeleteN.Location = new System.Drawing.Point(179, 188);
            this.buttonDeleteN.Name = "buttonDeleteN";
            this.buttonDeleteN.Size = new System.Drawing.Size(61, 23);
            this.buttonDeleteN.TabIndex = 6;
            this.buttonDeleteN.Text = "Delete";
            this.buttonDeleteN.UseVisualStyleBackColor = true;
            this.buttonDeleteN.Click += new System.EventHandler(this.buttonDeleteN_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(12, 64);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(61, 23);
            this.buttonRandomize.TabIndex = 7;
            this.buttonRandomize.Text = "Generate";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(93, 64);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(61, 23);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 223);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.buttonDeleteN);
            this.Controls.Add(this.checkBoxLastN);
            this.Controls.Add(this.checkBoxFirstN);
            this.Controls.Add(this.textBoxLastN);
            this.Controls.Add(this.textBoxFirstN);
            this.Controls.Add(this.usedNamesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fantasy name generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBoxFirstN;
        public System.Windows.Forms.CheckBox checkBoxLastN;

        private System.Windows.Forms.Button buttonDeleteN;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonAccept;
        public System.Windows.Forms.TextBox textBoxFirstN;
        public System.Windows.Forms.TextBox textBoxLastN;
        public System.Windows.Forms.ListBox usedNamesList;
    }
}

