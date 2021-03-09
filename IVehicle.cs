using System;
using System.Collections.Generic;
using System.Text;

namespace sss
{
    interface IVehicle
    {
        string Name { get; set; }
        double Speed { get; set; }


        void Flight()
        {
            Console.WriteLine("5 минут полёт нормальный");
        }

        void Landing()
        {
            Console.WriteLine("Посадка прошла успешно");
        }

        void TTC()
        {
            Console.WriteLine("Название летательного аппарата: " + Name +
                              "\n" + "Скорость: " + Speed);
        }
    }


}