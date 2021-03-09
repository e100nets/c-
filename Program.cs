using System;
namespace sss
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle mig25 = new Airplane("Миг-25", 1300, 8600);
            IVehicle vasya = new Helicopter("Вася", 400, 800, 20000);
            IVehicle hangGlider = new HangGlider("Дельтаплан", 140);

            Console.WriteLine("ТТХ самолёта: ");
            mig25.TTC();
            mig25.Flight();
            Console.WriteLine("Состояние после посадки: ");
            mig25.Landing();
            hangGlider.TTC();
            hangGlider.Flight();
            hangGlider.Landing();
            Console.WriteLine("ТТХ вертолёта: ");
            vasya.TTC();
            Console.WriteLine("Состояние после посадки: ");
            vasya.Landing();


            /*mig25.Flight();
            mig25.Landing();
            vasya.Flight();
            vasya.Landing();
            vasya.TTC();
            hangGlider.Flight();
            hangGlider.Landing();*/
        }
    }
}
