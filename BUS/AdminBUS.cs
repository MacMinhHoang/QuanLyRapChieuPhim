﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AdminBUS
    {
        private AdminDAO adminDAO;

        public AdminBUS()
        {
            adminDAO = new AdminDAO();
        }

        public List<NhanVienKTDTO> LayDanhSach()
        {
            return adminDAO.LayDanhSach();
        }

        public NhanVienKTDTO LayThongTin(string tendangnhap)
        {
            return adminDAO.LayThongTin(tendangnhap);
        }

        public void SuaThongTin(NhanVienKTDTO ad)
        {
            adminDAO.SuaThongTin(ad);
        }
    }
}
