﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1.DataControler;
using DuAn1.DataControler.DataDuAnTableAdapters;

namespace DuAn1.LoginControler
{
    public class LoginRes
    {
        public static DataRow UserProperties;
        public static Dashboard dashboard;

        public static DataRow Login(string user, string password)
        {

            var TaiKhoanData = new TaiKhoanTableAdapter();
            DataRow check = TaiKhoanData.GetData().FirstOrDefault(tk => tk.userName.Equals(user) && tk.passWord.Equals(password));
            return check;
        }
    }
}