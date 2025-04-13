using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace jsquareMVVM.DataAccess.Interface
{
    public interface IEmployee
    {
        public int saveData();


        /// <summary>
        /// Default interface
        /// </summary>
        /// <returns></returns>
        public int clearData()
        {
            return 1;
        }
    }
}


     
    

