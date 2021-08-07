using System;
namespace MyApplication
{
    public class ItallianChef : Chef
    {
        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
