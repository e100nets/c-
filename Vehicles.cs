using System;
using System.Collections.Generic;
using System.Text;

namespace sss
{
    class Helicopter : IVehicle
    {

        public Helicopter(string name, double speed, double maxRange, double distance)
        {
            Name = name;
            Speed = speed;
            MaxRange = maxRange;
            Distance = distance;
        }
        public string Name { get; set; }
        public double Speed { get; set; }
        public double MaxRange { get; set; }
        public double Distance { get; set; }

        public void Landing()
        {
            if (Distance < MaxRange)
            {
                Console.WriteLine("Вертолёт " + Name + " удачно приземлился");
            }

            else
            {
                Console.WriteLine("Не повезло, не фортануло");
            }
        }

        public void TTC()
        {
            Console.WriteLine("Название вертолёта: " + Name +
                              "\n Скорость: " + Speed +
                              "\n Максимальная дистанция полёта: " + MaxRange);
        }
    }

    class HangGlider : IVehicle
    {
        public HangGlider(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }
        public string Name { get; set; }
        public double Speed { get; set; }
    }

    class Airplane : IVehicle
    {
        public Airplane(string name, double speed, double maxHeight)
        {
            Name = name;
            Speed = speed;
            MaxHeight = maxHeight;
        }

        public string Name { get; set; }
        public double Speed { get; set; }

        public double MaxHeight { get; set; }

        public void Flight()
        {
            Console.WriteLine("Самолёт " + Name + " летит на высоте " + MaxHeight +
                              " со скоростью " + Speed);
        }

        public void Landing()
        {
            Random r = new Random();
            int a = r.Next(1, 10);

            if (a > 5)
            {
                Console.WriteLine("Самолёт " + Name + " удачно приземлился");
            }

            else
            {
                Console.WriteLine("Бабах");
            }
        }

        public void TTC()
        {
            Console.WriteLine("Название самолёта: " + Name +
                              "\n Скорость: " + Speed +
                              " \n Максимальная высота: " + MaxHeight);
        }
    }
}
