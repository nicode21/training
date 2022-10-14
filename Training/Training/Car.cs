using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Car
    {
        public string price;

        public void CarValue()
        {


            while (true)
            {
                int carPrice = int.Parse(Console.ReadLine());
                if (carPrice == 0)
                {
                    break;
                }

                if (carPrice < 15000 && 0 < carPrice)
                {
                    Console.WriteLine("UCUZ");
                }
                else if (carPrice <= 30000 && carPrice >= 15000)
                {
                    Console.WriteLine("ORTA");
                }
                else if(carPrice > 30000)
                {
                    Console.WriteLine("BAHA");
                }
                else
                {
                    Console.WriteLine("Duzgun qiymet girin");
                }
            }
        }
    }
}
