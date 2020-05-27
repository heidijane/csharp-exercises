using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        //both these shouldn't be changed so keep them private
        private string _cityName;
        private int _yearEstablished = DateTime.Now.Year;

        //don't want user to change this directly, only view it
        public List<Building> CityBuildings { get; } = new List<Building>();

        //mayor might change at some point to make this public
        public string MayorName { get; set; }

        public City(string name, int year = 0)
        {
            _cityName = name;
            if (year != 0)
            {
                _yearEstablished = year;
            }
        }

        public void AddBuilding(Building building)
        {
            CityBuildings.Add(building);
        }
    }
}