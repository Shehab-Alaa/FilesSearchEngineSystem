namespace FilesSearchEngineSystem
{
    partial class mainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.functionsPanel = new System.Windows.Forms.Panel();
            this.categoryInformationBtn = new System.Windows.Forms.Button();
            this.fileContentBtn = new System.Windows.Forms.Button();
            this.displayFilesInfoBtn = new System.Windows.Forms.Button();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.displayCategoryKeywordBtn = new System.Windows.Forms.Button();
            this.displayFileCategoriesBtn = new System.Windows.Forms.Button();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.functionsTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.pages = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.functionsPanel.SuspendLayout();
            this.functionsTitle.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // functionsPanel
            // 
            this.functionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.functionsPanel.Controls.Add(this.categoryInformationBtn);
            this.functionsPanel.Controls.Add(this.fileContentBtn);
            this.functionsPanel.Controls.Add(this.displayFilesInfoBtn);
            this.functionsPanel.Controls.Add(this.addCategoryBtn);
            this.functionsPanel.Controls.Add(this.displayCategoryKeywordBtn);
            this.functionsPanel.Controls.Add(this.displayFileCategoriesBtn);
            this.functionsPanel.Controls.Add(this.addFileBtn);
            this.functionsPanel.Controls.Add(this.functionsTitle);
            this.functionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.functionsPanel.Location = new System.Drawing.Point(0, 0);
            this.functionsPanel.Name = "functionsPanel";
            this.functionsPanel.Size = new System.Drawing.Size(144, 346);
            this.functionsPanel.TabIndex = 0;
            // 
            // categoryInformationBtn
            // 
            this.categoryInformationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.categoryInformationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryInformationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryInformationBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.categoryInformationBtn.Location = new System.Drawing.Point(3, 256);
            this.categoryInformationBtn.Name = "categoryInformationBtn";
            this.categoryInformationBtn.Size = new System.Drawing.Size(137, 35);
            this.categoryInformationBtn.TabIndex = 8;
            this.categoryInformationBtn.Text = "Category Info";
            this.categoryInformationBtn.UseVisualStyleBackColor = false;
            this.categoryInformationBtn.Click += new System.EventHandler(this.categoryInformationBtn_Click_1);
            // 
            // fileContentBtn
            // 
            this.fileContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.fileContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContentBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileContentBtn.Location = new System.Drawing.Point(3, 297);
            this.fileContentBtn.Name = "fileContentBtn";
            this.fileContentBtn.Size = new System.Drawing.Size(137, 35);
            this.fileContentBtn.TabIndex = 7;
            this.fileContentBtn.Text = "File Content";
            this.fileContentBtn.UseVisualStyleBackColor = false;
            this.fileContentBtn.Click += new System.EventHandler(this.fileContentBtn_Click_1);
            // 
            // displayFilesInfoBtn
            // 
            this.displayFilesInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.displayFilesInfoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.displayFilesInfoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.displayFilesInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayFilesInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFilesInfoBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.displayFilesInfoBtn.Location = new System.Drawing.Point(3, 91);
            this.displayFilesInfoBtn.Name = "displayFilesInfoBtn";
            this.displayFilesInfoBtn.Size = new System.Drawing.Size(137, 35);
            this.displayFilesInfoBtn.TabIndex = 6;
            this.displayFilesInfoBtn.Text = "Files Information";
            this.displayFilesInfoBtn.UseVisualStyleBackColor = false;
            this.displayFilesInfoBtn.Click += new System.EventHandler(this.displayFilesInfoBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.addCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addCategoryBtn.Location = new System.Drawing.Point(3, 132);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(137, 35);
            this.addCategoryBtn.TabIndex = 5;
            this.addCategoryBtn.Text = "Add New Category";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // displayCategoryKeywordBtn
            // 
            this.displayCategoryKeywordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.displayCategoryKeywordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayCategoryKeywordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCategoryKeywordBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.displayCategoryKeywordBtn.Location = new System.Drawing.Point(3, 214);
            this.displayCategoryKeywordBtn.Name = "displayCategoryKeywordBtn";
            this.displayCategoryKeywordBtn.Size = new System.Drawing.Size(137, 35);
            this.displayCategoryKeywordBtn.TabIndex = 4;
            this.displayCategoryKeywordBtn.Text = "Category Keywords";
            this.displayCategoryKeywordBtn.UseVisualStyleBackColor = false;
            this.displayCategoryKeywordBtn.Click += new System.EventHandler(this.displayCategoryKeywordBtn_Click);
            // 
            // displayFileCategoriesBtn
            // 
            this.displayFileCategoriesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.displayFileCategoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayFileCategoriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFileCategoriesBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.displayFileCategoriesBtn.Location = new System.Drawing.Point(3, 173);
            this.displayFileCategoriesBtn.Name = "displayFileCategoriesBtn";
            this.displayFileCategoriesBtn.Size = new System.Drawing.Size(137, 35);
            this.displayFileCategoriesBtn.TabIndex = 3;
            this.displayFileCategoriesBtn.Text = "File Categories";
            this.displayFileCategoriesBtn.UseVisualStyleBackColor = false;
            this.displayFileCategoriesBtn.Click += new System.EventHandler(this.displayFileCategoriesBtn_Click);
            // 
            // addFileBtn
            // 
            this.addFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.addFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.addFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.addFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFileBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addFileBtn.Location = new System.Drawing.Point(3, 50);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(137, 35);
            this.addFileBtn.TabIndex = 2;
            this.addFileBtn.Text = "Add New File";
            this.addFileBtn.UseVisualStyleBackColor = false;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // functionsTitle
            // 
            this.functionsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.functionsTitle.Controls.Add(this.label1);
            this.functionsTitle.Location = new System.Drawing.Point(0, 0);
            this.functionsTitle.Name = "functionsTitle";
            this.functionsTitle.Size = new System.Drawing.Size(144, 41);
            this.functionsTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files System";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.White;
            this.titleBar.Controls.Add(this.minimizeBtn);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(144, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(624, 38);
            this.titleBar.TabIndex = 1;
            // 
            // pages
            // 
            this.pages.Location = new System.Drawing.Point(144, 25);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(624, 321);
            this.pages.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(599, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 32);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(576, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(17, 50);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(768, 346);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.functionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files System";
            this.functionsPanel.ResumeLayout(false);
            this.functionsTitle.ResumeLayout(false);
            this.functionsTitle.PerformLayout();
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel functionsPanel;
        private System.Windows.Forms.Button categoryInformationBtn;
        private System.Windows.Forms.Button fileContentBtn;
        private System.Windows.Forms.Button displayFilesInfoBtn;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Button displayCategoryKeywordBtn;
        private System.Windows.Forms.Button displayFileCategoriesBtn;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.Panel functionsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel pages;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}

