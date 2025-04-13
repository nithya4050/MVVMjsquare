using jsquareMVVM.DataAccess;
using jsquareMVVM.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsquareMVVM.DataAccess
{
    public class StudentData : Student
    {
        public override string Getconnection()
        {
            throw new NotImplementedException();
        }

        public int save()
        {
            SaveData(Getconnection());
            return 1;
        }
    }

}
