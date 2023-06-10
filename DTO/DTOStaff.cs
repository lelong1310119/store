using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class DTOStaff
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public DateTime DateReceived { get; set; }
        public string Address { get; set; }
        public string Phone  { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public DTOStaff()
        {

        }

        public DTOStaff(int iD, string name, DateTime dateReceived, string address, string phone, string gender)
        {
            ID = iD;
            Name = name;
            DateReceived = dateReceived;
            Address = address;
            Phone = phone;
            Gender = gender;
        }

        public DTOStaff(string name, DateTime date, string address, string phone, string gender)
        {
            Name = name;
            Address = address;
            DateReceived = date;
            Phone = phone;
            Gender = gender;
        }
    }
}
