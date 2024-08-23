using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.entity
{
  public class Parceldetails
    {
        public long ParcelID { get; set; }
        public string FromAddress { get; set; }
        public string TOAddress { get; set; }
        public long NetWeight { get; set; }
        public long Price { get; set; }
        public DateTime Date { get; set; }
        public string ParcelServiceName { get; set; }
     
    }
}
