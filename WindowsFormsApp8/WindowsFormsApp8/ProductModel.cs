using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class ProductModel
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }

        public ProductModel()
        {
        }

        public ProductModel(string maSP, string tenSP, decimal gia)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Gia = gia;
        }
    }
}
