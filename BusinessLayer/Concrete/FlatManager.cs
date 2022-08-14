using BusinessLayer.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FlatManager : IFlatService
    {
        IFlatDal _flatDal;

        public FlatManager(IFlatDal houseDal)
        {
            _flatDal = houseDal;
        }        

        public Flat GetById(int id)
        {
            return _flatDal.GetById(id);
        }

        public List<Flat> GetList()
        {
            return _flatDal.GetListAll();
        }

        public List<Flat> GetLoggedUserHouse(int id)
        {
            return _flatDal.GetLoggedUserHouse(id);
        }

        public void TAdd(Flat t)
        {
            _flatDal.Insert(t);
        }

        public void TDelete(Flat t)
        {
            _flatDal.Delete(t);
        }

        public void TUpdate(Flat t)
        {
            _flatDal.Update(t);
        }
    }
}
