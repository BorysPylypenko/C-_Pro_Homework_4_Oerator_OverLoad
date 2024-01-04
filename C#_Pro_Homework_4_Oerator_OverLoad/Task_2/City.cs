using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_2
{
    public class City
    {
        public string City_Name { get; set; }
        public int Qty_Citizen { get; set; }

        public City(string city_name, int qty_citizen)
        {
            City_Name = city_name;
            Qty_Citizen = qty_citizen;
        }

        public static City operator +(City city, int increase)
        {
            city.Qty_Citizen += increase;
            return city;
        }

        public static City operator -(City city, int decrease)
        {
            city.Qty_Citizen -= decrease;
            return city;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Qty_Citizen > city2.Qty_Citizen;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Qty_Citizen < city2.Qty_Citizen;
        }

        public static bool operator == (City city1, City city2)
        {
            return city1.Qty_Citizen == city2.Qty_Citizen;
        }

        public static bool operator != (City city1, City city2)
        {
            return city1.Qty_Citizen != city2.Qty_Citizen;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() == obj.GetType()) return false;

            City city = (City)obj;
            return this.Qty_Citizen == city.Qty_Citizen;
        }

        public override int GetHashCode()
        {
            return Qty_Citizen.GetHashCode();
        }

    }
}
