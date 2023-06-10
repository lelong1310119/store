using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public int Price { get; set; }
        public string Image { get; set; }

        public DTOProduct(int iD, string name, int price, string image)
        {
            ID = iD;
            Name = name;
            Price = price;
            Image = image;
        }

        public DTOProduct(int iD, string name, int price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public DTOProduct(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public DTOProduct()
        {
           
        }
    }
}
