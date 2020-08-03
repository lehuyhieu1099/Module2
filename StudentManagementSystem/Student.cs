using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StudentManagementSystem
{
    class Student : IStudent
    {
        private string fullName;
        private int iD;
        private DateTime dateofBirth;
        private string address;
        private string _class;
        private string phoneNo;
        private int mobile;

        public string FullName { get => fullName; set => fullName = value; }
        public string ID { get => ID;}
        public string DateofBirth { get => DateofBirth; set => DateofBirth = value; }
        public string Adress { get => Adress; set => Adress = value; }
        public string Class { get => Class; set => Class = value; }
        public string PhoneNo { get => PhoneNo; set => PhoneNo = value; }
        public string Mobile { get => Mobile; set => Mobile = value; }





        public string DisplayInfo()
        {
            return $"Name: {fullName}, ID: {iD}, " +
                $"DateofBirth: {dateofBirth}, Address: {address}, Class: {_class}, " +
                $"PhoneNumber: {phoneNo}, Mobile: {mobile}";
        }
    }
}
