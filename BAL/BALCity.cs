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
    public class BALCity
    {
        DALcity dal;
        public BALCity()
        {
            dal = new DALcity();
        }

        public DataTable GetAllCity()
        {
            return dal.getAllcity();
        }
        public bool UpdateSV(DTOCity city)
        {
            return UpdateSV(city);
        }
        public bool InsertSV(DTOCity city)
        {
            return InsertSV(city);
        }
        public bool DeleteSV(DTOCity city)
        {
            return DeleteSV(city);
        }
    }
}
