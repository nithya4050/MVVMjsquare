using jsquareMVVM.Helper;
using jsquareMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using jsquareMVVM.DataAccess.Interface;
using jsquareMVVM.DataAccess;

namespace jsquareMVVM.ViewModel
{
    public class HomeViewModel
    {
        public ClickEvent SaveData { get; set; }
        public ClickEvent ClearData { get; set; }
        public ClickEvent UpdateData { get; set; }


        private HomeModel _homeModel;
        public HomeModel HomeFields
        {
            get { return _homeModel; }
            set { _homeModel = value; }
        }


        private ObservableCollection<HomeModel> _homelist;
        public ObservableCollection<HomeModel> HomeLists
        {
            get { return _homelist; }
            set { _homelist = value; }
        }

        public HomeViewModel()
        {
            SaveData = new ClickEvent(Save);
            ClearData = new ClickEvent(Clear);
            HomeFields = new HomeModel();
            HomeLists = new ObservableCollection<HomeModel>();
            HomeLists.Add(new HomeModel
            {
                Name = "Nithya",
                Age = 25,
                Lastname = "S",
                Education = "MCA",
                Place = "Kovai",
                PhoneNo = "9988738983",
                Dateofbirth = "11-02-2000"
            });

        }

        
        public void Save()
        {
            HomeLists.Add(new HomeModel
            {
                Name = HomeFields.Name,
                Age = HomeFields.Age,
                Lastname = HomeFields.Lastname,
                Education = HomeFields.Education,
                Place = HomeFields.Place,
                PhoneNo = HomeFields.PhoneNo,
                Dateofbirth = HomeFields.Dateofbirth
            });
        }

        public void select()
        {
             
        }

        public void Clear()
        {
            HomeFields.Name = "";
            HomeFields.Lastname = "";
            HomeFields.Age = 0;
            HomeFields.Education = "";
            HomeFields.Dateofbirth = "";
            HomeFields.Place = "";
            HomeFields.PhoneNo = "";

            ///
            /// Filter 
            /// Interface Method
            ///

            DataAccess.Class1 oc;
            oc = new DataAccess.Class1();

            IEmployee emp;
            // emp = new DataAccess.Class1();
            //emp.saveData();

            string query = "";
            IDataAccess dataAccess;
            dataAccess = new DataAccess.Class1();
            dataAccess.ExecuteNonQuery(query);
        }
    }
}
