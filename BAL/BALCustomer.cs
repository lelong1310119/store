using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BALCustomer
    {
        DALCustomer dal;
        public BALCustomer()
        {
            dal = new DALCustomer();
        }

        public DataTable GetAllcustomer()
        {
            return dal.getAllCustomer();
        }
        public bool UpdateSV(DTOCustomer customer)
        {
            return UpdateSV(customer);
        }
        public bool InsertSV(DTOCustomer customer)
        {
            return InsertSV(customer);
        }
        public bool DeleteSV(DTOCustomer customer)
        {
            return DeleteSV(customer);
        }
    }
}
