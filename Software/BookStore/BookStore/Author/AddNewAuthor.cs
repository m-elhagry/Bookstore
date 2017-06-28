using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Author
{
    public partial class AddNewAuthor : Form
    {
        public AddNewAuthor()
        {
            InitializeComponent();
        }
        DAL.DataAcessLayer Flash = new DAL.DataAcessLayer();
        public bool AddState = true;
        public string NameForUpdate = "";
        AuthorClass Author;
        private void Test()
        {
            if (!Flash.Flash())
            {
                MessageBox.Show("There Is A Problem In Flash", "Flash Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void AddNewAuthor_Load(object sender, EventArgs e)
        {
            Author = new AuthorClass();
            Test();
            if (AddState == true)//في حالة الاضافة
            {
                this.Text = "Add New Author";//تعديل اسم الفورم
                TxtId.Text = Author.AuthorNextId().Rows[0][0].ToString();
            }
            else//في حالة التعديل
                this.Text = "Update Author";//تعديل اسم الفورم
            Test();
        }
        private void TxtName_Validated(object sender, EventArgs e)
        {
            Author = new AuthorClass();
            if (Author.AuthorCheckName(TxtName.Text).Rows.Count > 0)
            {
                if (AddState == true || TxtName.Text != NameForUpdate)
                {
                    MessageBox.Show("This Name Was Exixt Before", "Add Author Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtName.Focus();
                    return;
                }
            }
        }
        private void TxtPassword_Validated(object sender, EventArgs e)
        {
            if (TxtPassword.Text != Program.pass)
            {
                MessageBox.Show("Sorry, Your Password Wrong", "Add Author Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }
        }
        private void BtnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '\0';//اظهار الباسوورد وتحويله الي كلام مفهوم
        }
        private void BtnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '*';//اخفاء الباسوورد وتحويله الي نجوم
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Author = new AuthorClass();
            try
            {
                Test();
                if (TxtId.Text == String.Empty || TxtName.Text == String.Empty || TxtPassword.Text == String.Empty)
                {
                    MessageBox.Show("Sorry, Your Data Not Complete", "Add Author Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AddState == true)
                {
                    Author.AuthorAddNew(TxtName.Text);
                    DialogResult R = MessageBox.Show("Added Successfully\nDo You Want Add Another Author", "Add Author Feedback", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (R == DialogResult.Yes)//لو الادمن عايز يضيف حد تاني بفضيله الخانات
                    {
                        TxtId.Text = Author.AuthorNextId().Rows[0][0].ToString();
                        TxtName.Clear();
                        TxtPassword.Clear();
                    }
                    else
                        this.Close();
                }
                else
                {
                    Author.AuthorUpdate(Convert.ToInt32(TxtId.Text), TxtName.Text);
                    MessageBox.Show("Updated Successfully", "Update Author Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                Test();
            }
            catch { return; }
        }
    }
}
