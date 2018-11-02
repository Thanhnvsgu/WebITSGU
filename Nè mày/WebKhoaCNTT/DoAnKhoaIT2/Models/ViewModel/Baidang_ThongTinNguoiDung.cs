using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModel
{
    public class Baidang_ThongTinNguoiDung
    {
        public string Mabaidang { get; set; }
        public string Noidung { set; get; }
        public string Tentieude { set; get; }
        public string Dinhkem { set; get; }        
        public string HoTen { set; get; }
        public DateTime? Ngaydang { set; get; }
    }
}
