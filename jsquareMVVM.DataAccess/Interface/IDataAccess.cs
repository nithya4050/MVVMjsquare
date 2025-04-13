using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsquareMVVM.DataAccess.Interface
{
    public interface IDataAccess
    {
        public int ExecuteNonQuery(string query);
        public int GetData(string query);
        public int LoginCheck(string query);
    }
}
