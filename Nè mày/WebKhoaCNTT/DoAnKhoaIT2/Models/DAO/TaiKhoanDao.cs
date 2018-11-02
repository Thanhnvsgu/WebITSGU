﻿using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class TaiKhoanDao
    {
        SGU db = null;
        public TaiKhoanDao()
        {
            db = new SGU();
        }
        public int login(string UserName, string Password)
        {
            var result = db.Taikhoans.SingleOrDefault(x => x.Tentaikhoan == UserName);
            if (result == null) return -1;
            else
                if (result.Matkhau == Password && result.Flag.GetValueOrDefault())
            {

                return 1;
            }
            else
                if (!result.Flag.GetValueOrDefault()) return 2;
            else
                return 0;
        }

        public Taikhoan GetById(string UserName)
        {
            return db.Taikhoans.SingleOrDefault(x => x.Tentaikhoan == UserName);
        }
    }
}
