using System;
using DesafioPooDio_GFT_4.src.Entities;

namespace DesafioPooDio_GFT_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "Wizard");
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine("__________________________________");
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine("__________________________________");
            Console.WriteLine(blackWizard.Attack(7));
            Console.WriteLine("__________________________________");
            Console.WriteLine(ninja.Attack());

        }
    }
}
