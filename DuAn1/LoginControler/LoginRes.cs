﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataControler;
using WindowsFormsApp1.DataControler.DataDuAnTableAdapters;

namespace WindowsFormsApp1.LoginControler
{
    public class LoginRes
    {
        public static DataRow UserProperties;
        public static DataRow Login(string user, string password)
        {

            var TaiKhoanData = new TaiKhoanTableAdapter();
            DataRow check = TaiKhoanData.GetData().FirstOrDefault(tk => tk.Field<string>("userName").Equals(user) && tk.Field<string>("passWord").Equals(password));
            return check;
        }
    }
}