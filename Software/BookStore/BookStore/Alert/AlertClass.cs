using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookStore.Alert
{
    class AlertClass
    {
        DataTable DT;
        DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
        public DataTable BookAlertSearch()
        {
            //بيجيب كل الانواع اللي اقل من الكمية المحددة
            DT = new DataTable();
            DT = DAL.SelectData("BookAlertSearch", null);
            return DT;
        }
    }
}
