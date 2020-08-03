using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    public interface IStudent
    {
        string fullName { get; set; }
        int iD { get;}
        DateTime dateofBirth { get; set; }
        string address { get; set; }
        string _class { get; set; }
        string phoneNo { get; set; }
        int mobile { get; set; }
        string DisplayInfo();
    }




}
