namespace BookStore.Author
{
    partial class SettingAuthorForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingAuthorForm));
            this.DgvAuthor = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnPrintThisAuthor = new System.Windows.Forms.Button();
            this.BtnPrintAuthorBooks = new System.Windows.Forms.Button();
            this.BtnPrintAuthorList = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAuthor
            // 
            this.DgvAuthor.AllowUserToAddRows = false;
            this.DgvAuthor.AllowUserToDeleteRows = false;
            this.DgvAuthor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DgvAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.DgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvAuthor.Location = new System.Drawing.Point(48, 67);
            this.DgvAuthor.MultiSelect = false;
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.ReadOnly = true;
            this.DgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAuthor.Size = new System.Drawing.Size(522, 208);
            this.DgvAuthor.TabIndex = 1;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(181, 18);
            this.TxtSearch.MaxLength = 50;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(283, 26);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon (153).png");
            this.imageList1.Images.SetKeyName(1, "Add-icon.png");
            this.imageList1.Images.SetKeyName(2, "Actions-document-edit-icon.png");
            this.imageList1.Images.SetKeyName(3, "128746-simple-red-square-icon-business-trashcan3.png");
            this.imageList1.Images.SetKeyName(4, "Delete.png");
            this.imageList1.Images.SetKeyName(5, "web-icon-pdf.png");
            this.imageList1.Images.SetKeyName(6, "excel-3-xxl.png");
            this.imageList1.Images.SetKeyName(7, "print_printer_printing_graphic_industry-512.png");
            this.imageList1.Images.SetKeyName(8, "printer.png");
            // 
            // BtnPrintThisAuthor
            // 
            this.BtnPrintThisAuthor.BackColor = System.Drawing.Color.White;
            this.BtnPrintThisAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintThisAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintThisAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrintThisAuthor.ImageIndex = 8;
            this.BtnPrintThisAuthor.ImageList = this.imageList1;
            this.BtnPrintThisAuthor.Location = new System.Drawing.Point(336, 368);
            this.BtnPrintThisAuthor.Name = "BtnPrintThisAuthor";
            this.BtnPrintThisAuthor.Size = new System.Drawing.Size(234, 40);
            this.BtnPrintThisAuthor.TabIndex = 7;
            this.BtnPrintThisAuthor.Text = "Print This Author";
            this.BtnPrintThisAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintThisAuthor.UseVisualStyleBackColor = false;
            this.BtnPrintThisAuthor.Click += new System.EventHandler(this.BtnPrintThisCategory_Click);
            // 
            // BtnPrintAuthorBooks
            // 
            this.BtnPrintAuthorBooks.BackColor = System.Drawing.Color.White;
            this.BtnPrintAuthorBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintAuthorBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAuthorBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrintAuthorBooks.ImageIndex = 7;
            this.BtnPrintAuthorBooks.ImageList = this.imageList1;
            this.BtnPrintAuthorBooks.Location = new System.Drawing.Point(181, 302);
            this.BtnPrintAuthorBooks.Name = "BtnPrintAuthorBooks";
            this.BtnPrintAuthorBooks.Size = new System.Drawing.Size(249, 40);
            this.BtnPrintAuthorBooks.TabIndex = 5;
            this.BtnPrintAuthorBooks.Text = "Print Author Books";
            this.BtnPrintAuthorBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintAuthorBooks.UseVisualStyleBackColor = false;
            this.BtnPrintAuthorBooks.Click += new System.EventHandler(this.BtnPrintProducts_Click);
            // 
            // BtnPrintAuthorList
            // 
            this.BtnPrintAuthorList.BackColor = System.Drawing.Color.White;
            this.BtnPrintAuthorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintAuthorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAuthorList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrintAuthorList.ImageIndex = 8;
            this.BtnPrintAuthorList.ImageList = this.imageList1;
            this.BtnPrintAuthorList.Location = new System.Drawing.Point(48, 368);
            this.BtnPrintAuthorList.Name = "BtnPrintAuthorList";
            this.BtnPrintAuthorList.Size = new System.Drawing.Size(217, 40);
            this.BtnPrintAuthorList.TabIndex = 6;
            this.BtnPrintAuthorList.Text = "Print Author List";
            this.BtnPrintAuthorList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintAuthorList.UseVisualStyleBackColor = false;
            this.BtnPrintAuthorList.Click += new System.EventHandler(this.BtnPrintAllCategory_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.ImageIndex = 3;
            this.BtnDelete.ImageList = this.imageList1;
            this.BtnDelete.Location = new System.Drawing.Point(630, 218);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(249, 40);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete This Author";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.ImageIndex = 2;
            this.BtnUpdate.ImageList = this.imageList1;
            this.BtnUpdate.Location = new System.Drawing.Point(629, 156);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(249, 40);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update This Author";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.ImageIndex = 4;
            this.BtnExit.ImageList = this.imageList1;
            this.BtnExit.Location = new System.Drawing.Point(696, 312);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(103, 40);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.ImageIndex = 1;
            this.BtnAdd.ImageList = this.imageList1;
            this.BtnAdd.Location = new System.Drawing.Point(640, 91);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(226, 40);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add New Author";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // SettingAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.book_660_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 426);
            this.Controls.Add(this.DgvAuthor);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrintThisAuthor);
            this.Controls.Add(this.BtnPrintAuthorBooks);
            this.Controls.Add(this.BtnPrintAuthorList);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(935, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(935, 465);
            this.Name = "SettingAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Author";
            this.Load += new System.EventHandler(this.SettingAuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvAuthor;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnPrintThisAuthor;
        private System.Windows.Forms.Button BtnPrintAuthorBooks;
        private System.Windows.Forms.Button BtnPrintAuthorList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
    }
}