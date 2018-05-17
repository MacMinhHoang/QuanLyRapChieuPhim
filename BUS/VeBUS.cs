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

        public void ThemVe(VeDTO ve)
        {
            veDAO.ThemVe(ve);
        }

        public void XoaVe(int mave)
        {
            veDAO.XoaVe(mave);
        }

        public int SoLuongVe()
        {
            return veDAO.SoLuongVe();
        }
    }
}
