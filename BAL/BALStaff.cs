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
    public class BALStaff
    {
        DALStaff dal;
        public BALStaff()
        {
            dal = new DALStaff();
        }

        public DataTable GetAllStaff()
        {
            return dal.getAllStaff();
        }
        public bool UpdateSV(DTOStaff staff)
        {
            return UpdateSV(staff);
        }
        public bool InsertSV(DTOStaff staff)
        {
            return InsertSV(staff);
        }
        public bool DeleteSV(DTOStaff staff)
        {
            return DeleteSV(staff);
        }
    }
}
