using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsquareMVVM.DataAccess.Interface
{
    public abstract class Student
    {
        public abstract string Getconnection();
        public int GetStudent(string connect)
        {
            return 1;
        }

        public int SaveData(string connect)
        {
            return 2;
        }
    }
}
