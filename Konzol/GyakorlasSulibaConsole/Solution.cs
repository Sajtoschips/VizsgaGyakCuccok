using GyakorlasSuliba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakorlasSuliba
{
    public static class Solution
    {
        public static List<Car>? Cars { get; set; } = Car.LoadFromJson("Files/cars.json").OrderBy(x => x.registration_date).ToList();
        public static List<Owner>? Owners { get; set; } = Owner.LoadFromJson("Files/owners.json");

        public static int CountCar()
        {
            return Cars.Count();
        }

        public static string GetDaysBetween()
        {
            Car firstCar = null;
            Car secondCar = null;
            double max = 0;
            for (int i = 0; i < Cars.Count-1; i++)
            {
                double daysBetween = Math.Floor((Cars[i + 1].registration_date - Cars[i].registration_date).TotalDays);
                if (daysBetween > max)
                {
                    max = daysBetween;
                    firstCar = Cars[i];
                    secondCar = Cars[i + 1];
                }
            }
            return $"A legtöbb idő a(z) {firstCar.brand} {firstCar.model} és a(z) {secondCar.brand} {secondCar.model} közt telt el, {max} nap!";

        }
    }
}
