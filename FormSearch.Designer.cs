namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    partial class FormSearch
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 10);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(219, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Search for anything";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.Location = new System.Drawing.Point(9, 32);
            this.searchResultsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(219, 316);
            this.searchResultsListBox.TabIndex = 1;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.searching_ico;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox searchResultsListBox;
    }
}