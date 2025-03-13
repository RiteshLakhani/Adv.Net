using System;

namespace Lab_1_Solution
{
    internal class Furniture
    {
        String Material;
        Double Price;
        public void GetData()
        {
            Console.Write("Enter Material : ");
            Material = Console.ReadLine();
            Console.Write("Enter Price : ");
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Material : " + Material);
            Console.WriteLine("Price : " + Price);
        }
    }

    class Table : Furniture
    {
        int Height, Surface_Area;
        public void GetData()
        {
            base.GetData();
            Console.Write("Enter height: ");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter surface area: ");
            Surface_Area = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Surface Area : " + Surface_Area);
        }
    }
}
