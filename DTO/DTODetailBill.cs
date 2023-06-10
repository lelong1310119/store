using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTODetailBill
    {
        public int IDProduct { get; set; }
        public int Quantity { get; set; }

        public DTODetailBill (int iDProduct, int quantity)
        {
            IDProduct = iDProduct;
            Quantity = quantity;
        }
    }
}
