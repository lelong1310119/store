using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOBill
    {
        public int ID { get; set; }
        public int IDCustomer { get; set; }
        public int IDStaff { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<DTODetailBill> details { get; set; }

        public DTOBill(int iD, int iDCustomer, int iDStaff, DateTime receivedDate, DateTime createdDate)
        {
            ID = iD;
            IDCustomer = iDCustomer;
            IDStaff = iDStaff;
            ReceivedDate = receivedDate;
            CreatedDate = createdDate;
            details = new List<DTODetailBill>();    
        }

        public DTOBill(int iDCustomer, int iDStaff, DateTime receivedDate, DateTime createdDate)
        {
            IDCustomer = iDCustomer;
            IDStaff = iDStaff;
            ReceivedDate = receivedDate;
            CreatedDate = createdDate;
            details = new List<DTODetailBill>();  
        }
    }
}
