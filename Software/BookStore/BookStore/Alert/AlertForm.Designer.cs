namespace BookStore.Alert
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnPrintThisAlert = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnPrintAllAlert = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.DgvAlert = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrintThisAlert
            // 
            this.BtnPrintThisAlert.BackColor = System.Drawing.Color.White;
            this.BtnPrintThisAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintThisAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintThisAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrintThisAlert.ImageIndex = 7;
            this.BtnPrintThisAlert.ImageList = this.imageList1;
            this.BtnPrintThisAlert.Location = new System.Drawing.Point(346, 360);
            this.BtnPrintThisAlert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrintThisAlert.Name = "BtnPrintThisAlert";
            this.BtnPrintThisAlert.Size = new System.Drawing.Size(208, 35);
            this.BtnPrintThisAlert.TabIndex = 2;
            this.BtnPrintThisAlert.Text = "Print This Alert";
            this.BtnPrintThisAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintThisAlert.UseVisualStyleBackColor = false;
            this.BtnPrintThisAlert.Click += new System.EventHandler(this.BtnPrintThisCategory_Click);
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
            // BtnPrintAllAlert
            // 
            this.BtnPrintAllAlert.BackColor = System.Drawing.Color.White;
            this.BtnPrintAllAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintAllAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAllAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrintAllAlert.ImageIndex = 8;
            this.BtnPrintAllAlert.ImageList = this.imageList1;
            this.BtnPrintAllAlert.Location = new System.Drawing.Point(76, 360);
            this.BtnPrintAllAlert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrintAllAlert.Name = "BtnPrintAllAlert";
            this.BtnPrintAllAlert.Size = new System.Drawing.Size(196, 35);
            this.BtnPrintAllAlert.TabIndex = 1;
            this.BtnPrintAllAlert.Text = "Print All Alert";
            this.BtnPrintAllAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintAllAlert.UseVisualStyleBackColor = false;
            this.BtnPrintAllAlert.Click += new System.EventHandler(this.BtnPrintAllCategory_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.ImageIndex = 4;
            this.BtnExit.ImageList = this.imageList1;
            this.BtnExit.Location = new System.Drawing.Point(634, 360);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(99, 35);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // DgvAlert
            // 
            this.DgvAlert.AllowUserToAddRows = false;
            this.DgvAlert.AllowUserToDeleteRows = false;
            this.DgvAlert.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DgvAlert.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAlert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAlert.BackgroundColor = System.Drawing.Color.White;
            this.DgvAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvAlert.Location = new System.Drawing.Point(38, 61);
            this.DgvAlert.Margin = new System.Windows.Forms.Padding(2);
            this.DgvAlert.MultiSelect = false;
            this.DgvAlert.Name = "DgvAlert";
            this.DgvAlert.ReadOnly = true;
            this.DgvAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlert.Size = new System.Drawing.Size(755, 286);
            this.DgvAlert.TabIndex = 0;
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.vector_background_9864488;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 405);
            this.Controls.Add(this.BtnPrintThisAlert);
            this.Controls.Add(this.BtnPrintAllAlert);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.DgvAlert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(855, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(855, 444);
            this.Name = "AlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.AlertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrintThisAlert;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnPrintAllAlert;
        private System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.DataGridView DgvAlert;
    }
}