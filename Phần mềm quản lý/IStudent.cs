using System;
using System.Collections.Generic;
using System.Text;

namespace Phần_mềm_quản_lý
{
    public interface IStudent
    {
        string FullName { get; set; }
        int ID { get; set; }
        DateTime DateofBirth { get; set; }
        string Address { get; set; }
        string Class { get; set; }
        string PhoneNo { get; set; }
        int Mobile { get; set; }
        string DisplayInfo();
    }
}
