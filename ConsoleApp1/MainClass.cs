using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeuTesteAsync
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            Write(ConsoleColor.White, "Hello! Let's prepare de coffee, the toasted bread!");
            Task.Delay(500);
            
            Task<Coffee> makeCoffeTask = Coffee.PrepararCafeAsync();
            Task<Bread> makeBreadTask = Bread.PutBreadInToast();
            await Task.WhenAll(makeCoffeTask, makeBreadTask);


            Coffee myCoffe = makeCoffeTask.Result;
            Bread myBread = makeBreadTask.Result;

            Write(ConsoleColor.White,"Our coffee is ready and it has " + myCoffe.amount +  "mL");
            Write(ConsoleColor.White,"Our bready is ready and it has " + myCoffe.amount +  "g");

            Task.Delay(1000);

            Write(ConsoleColor.White,"Ops, we forgot the eggs!");

            Egg ovo = await Egg.MakeEggs(3);

            Write(ConsoleColor.White, "Finished! We made " + ovo.amount + " eggs!");


            Console.ReadLine();
        }

        public static void Write(ConsoleColor color, string msg)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(msg);
        }

    }
}
