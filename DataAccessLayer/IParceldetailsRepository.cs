using DataAccessLayer.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IParceldetailsRepository
    {
        public void Details(Parceldetails reg);
        public void UpdateDetails(Parceldetails reg);
        public void DeleteDetails(long ParcelID);
        public List<Parceldetails> ShowAllParcel();
        public Parceldetails ShowParcelbyName(long ParcelId);


    }
}
