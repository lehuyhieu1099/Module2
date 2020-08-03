using System;
using System.Collections.Generic;
using System.Text;

namespace Phần_mềm_quản_lý
{
    class Student : IStudent
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }

       public string DisplayInfo()
        {
            return $"{FullName}\t\t{ID}\t\t{DateofBirth}\t\t{Address}\t{Class}\t\t{PhoneNo}\t{Mobile}";
        }
    }

}
