using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
            public InMemoryCarDal()
                {
              _cars = new List<Car>
                  {
                      new Car{Id=1, BrandId=2, ColorId=3, Description="Kırmızı Kapaklı", DilyPrice=35000, ModelYear=2019},
                      new Car{Id=2, BrandId=2, ColorId=4, Description="Yesil Kapaklı", DilyPrice=45000, ModelYear=2020},
                      new Car{Id=3, BrandId=3, ColorId=3, Description="Sarı Kapaklı", DilyPrice=55000, ModelYear=2021},
                      new Car{Id=4, BrandId=3, ColorId=4, Description="Mavi Kapaklı", DilyPrice=65000, ModelYear=2020},
                      new Car{Id=5, BrandId=4, ColorId=5, Description="Pembe Kapaklı", DilyPrice=75000, ModelYear=2021},
                      new Car{Id=6, BrandId=4, ColorId=5, Description="Siyah Kapaklı", DilyPrice=85000, ModelYear=2018}

                  };
                }




        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();

        }
        public List<Car> GetAll()
        {

            return _cars;
        }
        public List<Car> GetById( int Id)
        {

            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdated = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdated.Description = car.Description;
            carUpdated.ColorId = car.ColorId;
            carUpdated.DilyPrice = car.DilyPrice;
            carUpdated.BrandId = car.BrandId;
        }
    }
}
