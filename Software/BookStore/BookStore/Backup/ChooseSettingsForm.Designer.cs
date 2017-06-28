namespace BookStore.Backup
{
    partial class ChooseSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseSettingsForm));
            this.BtnRestore = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRestore
            // 
            this.BtnRestore.BackColor = System.Drawing.Color.White;
            this.BtnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRestore.ImageIndex = 1;
            this.BtnRestore.ImageList = this.imageList1;
            this.BtnRestore.Location = new System.Drawing.Point(141, 146);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(237, 58);
            this.BtnRestore.TabIndex = 1;
            this.BtnRestore.Text = "Restore Database";
            this.BtnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRestore.UseVisualStyleBackColor = false;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download_database_256.png");
            this.imageList1.Images.SetKeyName(1, "images.jpg");
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreate.ImageIndex = 0;
            this.BtnCreate.ImageList = this.imageList1;
            this.BtnCreate.Location = new System.Drawing.Point(141, 42);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(237, 58);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create Backup";
            this.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // ChooseSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.settings_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 246);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(534, 285);
            this.Name = "ChooseSettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnCreate;
    }
}