using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KeToanBUS
    {
        private KeToanDAO keToanDAO;

        public KeToanBUS()
        {
            keToanDAO = new KeToanDAO();
        }

        public List<KeToanDTO> LayDanhSach()
        {
            return keToanDAO.LayDanhSach();
        }

        public KeToanDTO LayThongTin(string tendangnhap)
        {
            return keToanDAO.LayThongTin(tendangnhap);
        }

        public void SuaThongTin(KeToanDTO kt)
        {
            keToanDAO.SuaThongTin(kt);
        }
    }
}
