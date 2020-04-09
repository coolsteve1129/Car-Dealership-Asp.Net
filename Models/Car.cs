using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Heck_16365660_AspNet_Asg5.Models
{
    public enum SortOrder
    {
        sortByMake,
        sortByYear,
        sortByPrice,
        sortByMileage,
        sortByColor,       
    }
    public class Car
    {

        private static int id;  // Used as Auto Increment ID


        public Car(string year, string makeModel, string price, string mileage, string color)
        {
            id++;
            ID = id;
            MakeModel = makeModel;
            Year = int.Parse(year);
            Price = int.Parse(price);
            Mileage = int.Parse(mileage);
            Color = color;
        }
        public int ID { get; set; }
        public string MakeModel { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public int Slug => ID;
        public SortOrder SortOrder { get; set; }


        public static void idMinusOne()
        {
            id--; ;
        }
        
        public static void setIdToZero()
        {
            id = 0;
        }
    }
           
}
