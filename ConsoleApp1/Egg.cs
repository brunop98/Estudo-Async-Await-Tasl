using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeuTesteAsync
{
    class Egg
    {

        public int amount;

        public Egg(int quantos)
        {
            amount = quantos;
        }

        public static async Task<Egg> MakeEggs(int quantos)
        {
            MainClass.Write(ConsoleColor.DarkGreen, "Start frying eggs");
            await Task.Delay(5000);
            MainClass.Write(ConsoleColor.DarkGreen, "Eggs are ready!");

            return new Egg(quantos);

        }

    }
}
