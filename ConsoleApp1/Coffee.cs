using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeuTesteAsync
{

    class Coffee
    {
        public float amount;

        public Coffee(float amount)
        {
            this.amount = amount;
        }

        public static async Task<Coffee> PrepararCafeAsync()
        {
            await BoilWater();
            await PutPowder();

            return new Coffee(300);
        }

        static async Task PutPowder()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Colocando o pó do café");
            await Task.Delay(1000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Pó colocado");
        }

        static async Task BoilWater()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Started boiling water");
            await Task.Delay(7000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Water is boiled");
        }

    }
}
