using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BookStore.Author
{
    class AuthorClass
    {
        DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
        DataTable DT;
        public DataTable AuthorNextId()
        {
            //جلب رقم المؤلف جديد
            DT = new DataTable();
            DT = DAL.SelectData("AuthorNextId", null);
            return DT;
        }
        public DataTable AuthorAddNew(string AuthorName)
        {
            //إضافة صنف جديد
            int AuthorId = Convert.ToInt32(AuthorNextId().Rows[0][0].ToString());

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@AuthorId", SqlDbType.Int);
            param[0].Value = AuthorId;

            param[1] = new SqlParameter("@AuthorName", SqlDbType.NVarChar, 50);
            param[1].Value = AuthorName;

            DT = new DataTable();
            DT = DAL.SelectData("AuthorAddNew", param);
            return DT;
        }
        public DataTable AuthorUpdate(int AuthorId, string AuthorName)
        {
            //إضافة صنف جديد
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@AuthorId", SqlDbType.Int);
            param[0].Value = AuthorId;

            param[1] = new SqlParameter("@AuthorName", SqlDbType.NVarChar, 50);
            param[1].Value = AuthorName;

            DT = new DataTable();
            DT = DAL.SelectData("AuthorUpdate", param);
            return DT;
        }
        public DataTable BookAuthorSearchAll(string SearchWord)
        {
            //البحث في كل المؤلفين وجلب كل البيانات
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SearchWord", SqlDbType.NVarChar, 50);
            param[0].Value = SearchWord;

            DT = new DataTable();
            DT = DAL.SelectData("BookAuthorSearchAll", param);
            return DT;
        }
        public DataTable AuthorCheckName(string AuthorName)
        {
            //التاكد من عدم وجود اسمين
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@AuthorName", SqlDbType.NVarChar, 50);
            param[0].Value = AuthorName;

            DT = new DataTable();
            DT = DAL.SelectData("AuthorCheckName", param);
            return DT;
        }
        public void AuthorDelete(int AuthorId)
        {
            //حذف االصنف علي اساس رقمه
            SqlParameter[] param = new SqlParameter[1];
            DAL.open();

            param[0] = new SqlParameter("@AuthorId", SqlDbType.Int);
            param[0].Value = AuthorId;

            DAL.ExuteData("AuthorDelete", param);
            DAL.close();
        }
    }
}
