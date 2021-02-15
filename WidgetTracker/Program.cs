using System;

namespace WidgetTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Widget("Large", "red");
            Console.WriteLine($"W1 size: {w1.Size} color: {w1.Color}, Costs ${w1.Price()}");
        }
    }
}
