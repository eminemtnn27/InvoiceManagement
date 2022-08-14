using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IFlatDal:IGenericDal<Flat>
    {
        List<Flat> GetLoggedUserHouse(int id);
    }
}
