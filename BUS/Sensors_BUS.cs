using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class Sensors_BUS
    {
        public static List<Sensors_DTO> ListSensors_BUS()
        {
            return DAO.Sensors_DAO.ListSensors();
        }
    }
}
