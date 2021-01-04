using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeuTesteAsync
{
    class Bread
    {
        public float amount;

        public Bread(float g)
        {
            amount = g;
        }

        public static async Task<Bread> PutBreadInToast()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Start toasting bread");

            await Task.Delay(4000);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tosted bread is ready!");

            return new Bread(200);
        }

        public override string ToString()
        {
            return "Bread: " + amount + "g";
        }

    }
}
