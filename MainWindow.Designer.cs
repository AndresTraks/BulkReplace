namespace BulkReplace
{
    partial class MainWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.replacementList = new System.Windows.Forms.ListView();
            this.replace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.with = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directoryText = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryBrowseButton = new System.Windows.Forms.Button();
            this.replaceText = new System.Windows.Forms.TextBox();
            this.withText = new System.Windows.Forms.TextBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.withLabel = new System.Windows.Forms.Label();
            this.loadConfButton = new System.Windows.Forms.Button();
            this.saveConfButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // replacementList
            // 
            this.replacementList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replacementList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.replace,
            this.with});
            this.replacementList.FullRowSelect = true;
            this.replacementList.GridLines = true;
            this.replacementList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.replacementList.Location = new System.Drawing.Point(13, 118);
            this.replacementList.Name = "replacementList";
            this.replacementList.Size = new System.Drawing.Size(551, 97);
            this.replacementList.TabIndex = 2;
            this.replacementList.UseCompatibleStateImageBehavior = false;
            this.replacementList.View = System.Windows.Forms.View.Details;
            this.replacementList.SelectedIndexChanged += new System.EventHandler(this.replacementList_SelectedIndexChanged);
            // 
            // replace
            // 
            this.replace.Text = "Replace";
            this.replace.Width = 188;
            // 
            // with
            // 
            this.with.Text = "With";
            this.with.Width = 265;
            // 
            // directoryText
            // 
            this.directoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryText.Location = new System.Drawing.Point(76, 14);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(443, 20);
            this.directoryText.TabIndex = 0;
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 17);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(49, 13);
            this.directoryLabel.TabIndex = 2;
            this.directoryLabel.Text = "Directory";
            // 
            // directoryBrowseButton
            // 
            this.directoryBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryBrowseButton.Location = new System.Drawing.Point(526, 12);
            this.directoryBrowseButton.Name = "directoryBrowseButton";
            this.directoryBrowseButton.Size = new System.Drawing.Size(38, 23);
            this.directoryBrowseButton.TabIndex = 1;
            this.directoryBrowseButton.Text = "...";
            this.directoryBrowseButton.UseVisualStyleBackColor = true;
            this.directoryBrowseButton.Click += new System.EventHandler(this.directoryBrowseButton_Click);
            // 
            // replaceText
            // 
            this.replaceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceText.Location = new System.Drawing.Point(68, 222);
            this.replaceText.Multiline = true;
            this.replaceText.Name = "replaceText";
            this.replaceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.replaceText.Size = new System.Drawing.Size(496, 63);
            this.replaceText.TabIndex = 4;
            this.replaceText.TextChanged += new System.EventHandler(this.replaceText_TextChanged);
            // 
            // withText
            // 
            this.withText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.withText.Location = new System.Drawing.Point(68, 291);
            this.withText.Multiline = true;
            this.withText.Name = "withText";
            this.withText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.withText.Size = new System.Drawing.Size(496, 63);
            this.withText.TabIndex = 5;
            this.withText.TextChanged += new System.EventHandler(this.withText_TextChanged);
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(15, 222);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(47, 13);
            this.replaceLabel.TabIndex = 6;
            this.replaceLabel.Text = "Replace";
            // 
            // withLabel
            // 
            this.withLabel.AutoSize = true;
            this.withLabel.Location = new System.Drawing.Point(15, 294);
            this.withLabel.Name = "withLabel";
            this.withLabel.Size = new System.Drawing.Size(29, 13);
            this.withLabel.TabIndex = 7;
            this.withLabel.Text = "With";
            // 
            // loadConfButton
            // 
            this.loadConfButton.Location = new System.Drawing.Point(442, 52);
            this.loadConfButton.Name = "loadConfButton";
            this.loadConfButton.Size = new System.Drawing.Size(122, 23);
            this.loadConfButton.TabIndex = 8;
            this.loadConfButton.Text = "&Load Configuration";
            this.loadConfButton.UseVisualStyleBackColor = true;
            this.loadConfButton.Click += new System.EventHandler(this.loadConfButton_Click);
            // 
            // saveConfButton
            // 
            this.saveConfButton.Location = new System.Drawing.Point(442, 81);
            this.saveConfButton.Name = "saveConfButton";
            this.saveConfButton.Size = new System.Drawing.Size(122, 23);
            this.saveConfButton.TabIndex = 9;
            this.saveConfButton.Text = "&Save Configuration";
            this.saveConfButton.UseVisualStyleBackColor = true;
            this.saveConfButton.Click += new System.EventHandler(this.saveConfButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(68, 360);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 10;
            this.addItemButton.Text = "&Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(336, 52);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(100, 52);
            this.replaceButton.TabIndex = 11;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Filter";
            // 
            // filterText
            // 
            this.filterText.Location = new System.Drawing.Point(76, 54);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(254, 20);
            this.filterText.TabIndex = 13;
            this.filterText.Text = "*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 388);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.saveConfButton);
            this.Controls.Add(this.loadConfButton);
            this.Controls.Add(this.withLabel);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.withText);
            this.Controls.Add(this.replaceText);
            this.Controls.Add(this.directoryBrowseButton);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.directoryText);
            this.Controls.Add(this.replacementList);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "Bulk Text Replace Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView replacementList;
        private System.Windows.Forms.ColumnHeader replace;
        private System.Windows.Forms.ColumnHeader with;
        private System.Windows.Forms.TextBox directoryText;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Button directoryBrowseButton;
        private System.Windows.Forms.TextBox replaceText;
        private System.Windows.Forms.TextBox withText;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.Label withLabel;
        private System.Windows.Forms.Button loadConfButton;
        private System.Windows.Forms.Button saveConfButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterText;
    }
}

