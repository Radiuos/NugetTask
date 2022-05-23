using System;
using Humanizer;
namespace NugetTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeSpan.FromMilliseconds(3603001).Humanize(3));
            //Console.WriteLine(TimeSpan.FromMilliseconds(3603001));
        }
    }
}
