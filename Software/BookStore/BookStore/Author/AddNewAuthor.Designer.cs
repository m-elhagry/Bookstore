namespace BookStore.Author
{
    partial class AddNewAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAuthor));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnShowPass = new System.Windows.Forms.PictureBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.White;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.ImageIndex = 1;
            this.BtnCancel.ImageList = this.imageList1;
            this.BtnCancel.Location = new System.Drawing.Point(278, 178);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(128, 40);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "f18.png");
            this.imageList1.Images.SetKeyName(1, "Delete.png");
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.Transparent;
            this.TxtId.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.ForeColor = System.Drawing.Color.Black;
            this.TxtId.Location = new System.Drawing.Point(208, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(256, 30);
            this.TxtId.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 30);
            this.label9.TabIndex = 72;
            this.label9.Text = "Author Number:";
            // 
            // BtnShowPass
            // 
            this.BtnShowPass.BackColor = System.Drawing.Color.White;
            this.BtnShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShowPass.BackgroundImage")));
            this.BtnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowPass.Image = global::BookStore.Properties.Resources.signal1;
            this.BtnShowPass.Location = new System.Drawing.Point(435, 124);
            this.BtnShowPass.Name = "BtnShowPass";
            this.BtnShowPass.Size = new System.Drawing.Size(29, 30);
            this.BtnShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnShowPass.TabIndex = 71;
            this.BtnShowPass.TabStop = false;
            this.BtnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnShowPass_MouseDown);
            this.BtnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnShowPass_MouseUp);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(205, 124);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(232, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Validated += new System.EventHandler(this.TxtPassword_Validated);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 30);
            this.label6.TabIndex = 70;
            this.label6.Text = "Password:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.ImageIndex = 0;
            this.BtnSave.ImageList = this.imageList1;
            this.BtnSave.Location = new System.Drawing.Point(43, 178);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(139, 40);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Add";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.White;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.Location = new System.Drawing.Point(205, 74);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(259, 30);
            this.TxtName.TabIndex = 0;
            this.TxtName.Validated += new System.EventHandler(this.TxtName_Validated);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 69;
            this.label2.Text = "Author Name:";
            // 
            // AddNewAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.depositphotos_7185656_Books_seamless_pattern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 242);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnShowPass);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(526, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(526, 281);
            this.Name = "AddNewAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Author";
            this.Load += new System.EventHandler(this.AddNewAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox BtnShowPass;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
    }
}