using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private Int32 _MaKhachHang;
        private Int32 _DiemTichLuy;
      

        public int MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public int DiemTichLuy { get => _DiemTichLuy; set => _DiemTichLuy = value; }
        
    }
}
