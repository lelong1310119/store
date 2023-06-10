using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCity
    {
        public int ID { get; set; }
        public string Name { get; set; }    

        public DTOCity() { }
        public DTOCity(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public DTOCity( string name)
        {
            Name = name;
        }
    }
}
