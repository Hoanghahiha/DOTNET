using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDien.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int SLTieuThu { get; set; }
        public int DonGia { get; set; }
        public int DinhMuc { get; set; }
    }
}
