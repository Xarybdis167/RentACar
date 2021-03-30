using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Add(brandManager, colorManager);
            CarAdd(carManager);
            GetCarDetails(carManager);

        }

        private static void GetCarDetails(CarManager carManager)
        {
            var cars = carManager.GetCarDetails();
            foreach (var car in cars.Data)
            {
                Console.WriteLine(car.BrandName + " " + car.CarName + " Color:" + car.ColorName + " Price:" + car.DailyPrice);
            }
        }

        private static void CarAdd(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 8,
                ColorId = 3,
                DailyPrice = 0,
                Description = "2016 CHEVROLET CAMARO 2.0",
                Name = "Cammaro",
                ModelYear = 2016
            });
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 1,
                ModelYear = 2017,
                Name = "Clio",
                DailyPrice = 100,
                Description = "2017 CLIO 1.5 DCI ICON EDC"
            });
        }

        private static void Add(BrandManager brandManager, ColorManager colorManager)
        {
            colorManager.Add(new Color { Name = "Red" });
            colorManager.Add(new Color { Name = "White" });
            colorManager.Add(new Color { Name = "Black" });
            colorManager.Add(new Color { Name = "Blue" });
            colorManager.Add(new Color { Name = "Gray" });
            colorManager.Add(new Color { Name = "Lime" });
            brandManager.Add(new Brand { Name = "Opel" });
            brandManager.Add(new Brand { Name = "Fiat" });
            brandManager.Add(new Brand { Name = "Renault" });
            brandManager.Add(new Brand { Name = "Toyota" });
            brandManager.Add(new Brand { Name = "Peugeot" });
            brandManager.Add(new Brand { Name = "Volkswagen" });
            brandManager.Add(new Brand { Name = "Mercedes-Benz" });
            brandManager.Add(new Brand { Name = "Chevrolet" });
            brandManager.Add(new Brand { Name = "BMW" });
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Add(new Brand { Name = "Nissan" });
            brandManager.Add(new Brand { Name = "Hyundai" });
            brandManager.Add(new Brand { Name = "Audi" });
            brandManager.Add(new Brand { Name = "Volvo" });
            brandManager.Add(new Brand { Name = "Mazda" });
            brandManager.Add(new Brand { Name = "Citroën" });
        }
    }
}
