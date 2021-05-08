﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICarService
    {
        Car GetById(int id);

        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);

        List<Car> GetAllByDailyPrice(decimal min, decimal max);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
