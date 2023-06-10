using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCustomer
    {
        public int ID { get; set; } 
        public string Name { get; set; }    
        public string Address { get; set; }  
        public string Phone { get; set; }
        public int ID_City { get; set; }

        public DTOCustomer() { }
        public DTOCustomer(int iD, string name, string adress, string phone, int iD_City)
        {
            ID = iD;
            Name = name;
            Address = adress;
            Phone = phone;
            ID_City = iD_City;
        }

        public DTOCustomer(string name, string adress, string phone, int iD_City)
        {
            Name = name;
            Address = adress;
            Phone = phone;
            ID_City = iD_City;
        }
    }
}
