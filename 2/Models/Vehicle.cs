using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Models
{
    internal class Vehicle
    {
        private string _brand;
        public string Brand
        { 
            get
            {
                return _brand;
            }
            set
            {
                if( value.Length>3)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine(" Minimum 3 simvol olmalidir!");
                }
            }
        }


        private  string _model;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if ( value.Length>3)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Minimum 1 simvol olmalidir!");
                }
            }

        }

        private int  _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1900)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Minimum");
                }
            }
        }
        
        public int  MileageKm { get; set; }
        public bool IsRunning { get; set; }
        public Vehicle(string brand, string model, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;

        }
        
        public bool StartEngine()
        {
            IsRunning = true;
            return true;
        }
        public void Drive (int km)
        {
            if (IsRunning==true)
            {
                MileageKm += km;
            }
            if (IsRunning==false)
            {
                Console.WriteLine(MileageKm);
            }
        }
        public void VehicleInfo()
        {
            Console.WriteLine($" Brand; {Brand} ,Model; {Model}, Year: {Year}, Mileage:{MileageKm}, Running: {IsRunning}");
            
        }
    }
}
