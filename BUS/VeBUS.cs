using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class VeBUS
    {
        private VeDAO veDAO;

        public VeBUS()
        {
            veDAO = new VeDAO();
        }

        public List<VeDTO> LayDanhSach()
        {
            return veDAO.LayDanhSach();
        }

        public void ThemVe(string makh, string mave, string tenphim, string ngaychieu, string suatchieu,
           string mapc, string vitringoi, int gia)
        {
            veDAO.ThemVe(makh, mave, tenphim, ngaychieu, suatchieu, mapc, vitringoi, gia);
        }

        public void XoaVe(string mave)
        {
            veDAO.XoaVe(mave);
        }

        public int SoLuongVe()
        {
            return veDAO.SoLuongVe();
        }
    }
}
