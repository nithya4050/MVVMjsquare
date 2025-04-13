using jsquareMVVM.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsquareMVVM.Model
{
    public class HomeModel : Notify
    {

        //name
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                onproperty("Name");
            }


        }

        //Last Name
        private string _lname;
        public string Lastname
        {
            get { return _lname; }
            set
            {
                _lname = value;
                onproperty("Lastname");
            }
        }

        //Education
        private string _education;
        public string Education
        {
            get { return _education; }
            set
            {
                _education = value;
                onproperty("Education");

            }
        }

        //Dateofbirth
        private string _dateofbirth;
        public string Dateofbirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; onproperty("Dateofbirth"); }
        }

        //Age
        private int _age;
        public int Age
        {
            get { return _age;}
            set { _age = value; onproperty("Age");}
        }

        //Show
        private bool _show;
        public bool Show
        {
            get { return _show; }
            set
            {
                _show = value;
                onproperty("Show");
            }
        }







        //Place
        private string _place;
        public string Place
        {
            get { return _place; }
            set
            {
                _place = value;
                onproperty("Place");
            }
        }

        //Phone number
        private string _phoneno;
        public string PhoneNo
        {
            get { return _phoneno; }
            set
            {
                _phoneno = value;
                onproperty("PhoneNo");
            }
        }
    }
}
