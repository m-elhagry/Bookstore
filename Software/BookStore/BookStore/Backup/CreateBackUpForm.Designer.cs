namespace BookStore.Backup
{
    partial class CreateBackUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBackUpForm));
            this.LbLocation = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbLocation
            // 
            this.LbLocation.BackColor = System.Drawing.Color.White;
            this.LbLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbLocation.Cursor = System.Windows.Forms.Cursors.No;
            this.LbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLocation.Location = new System.Drawing.Point(20, 37);
            this.LbLocation.Name = "LbLocation";
            this.LbLocation.Size = new System.Drawing.Size(500, 25);
            this.LbLocation.TabIndex = 9;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.White;
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBrowse.ImageIndex = 2;
            this.BtnBrowse.Location = new System.Drawing.Point(20, 79);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(72, 35);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Delete.png");
            this.imageList1.Images.SetKeyName(1, "download_database_256.png");
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.ImageIndex = 0;
            this.BtnExit.ImageList = this.imageList1;
            this.BtnExit.Location = new System.Drawing.Point(389, 168);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(131, 44);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreate.ImageIndex = 1;
            this.BtnCreate.ImageList = this.imageList1;
            this.BtnCreate.Location = new System.Drawing.Point(20, 168);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(162, 44);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // CreateBackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.settings_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 248);
            this.Controls.Add(this.LbLocation);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(557, 287);
            this.Name = "CreateBackUpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Backup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbLocation;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCreate;
    }
}