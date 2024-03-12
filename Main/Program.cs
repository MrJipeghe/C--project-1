using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BauturiInfinity;
using BarInfinity;
using AlcoliceInfinity;
using Non_alcolice1Infinity;
using BereInfinity;
namespace T5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bere Tuborg = new Bere();
            Tuborg.settip("blonda");
            Tuborg.Test();

        }
    }
}
