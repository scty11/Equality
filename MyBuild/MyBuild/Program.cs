using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Food f1 = new Food("Chocolate", FoodType.Fat);
            Food f2 = new Food("Chocolate", FoodType.Fat);
            Food f3 = new Food("Bread", FoodType.Carb);

            CookedFood cf1 = new CookedFood(CookType.Melted, "chocolate", FoodType.Fat);
            CookedFood cf2 = new CookedFood(CookType.Melted, "chocolate", FoodType.Fat);
            CookedFood cf3 = new CookedFood(CookType.Toasted, "Bread", FoodType.Carb);

            DisplayWhetherEqual(f1, f2);
            DisplayWhetherEqual(f2, f3);
            DisplayWhetherEqual(cf1, cf2);
            DisplayWhetherEqual(cf2, cf3);
            DisplayWhetherEqual(cf2, f3);

            FoodItem banana = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodGroup.Sweets);

            Console.WriteLine(
                "banana    == banana2:   " + (banana == banana2));
            Console.WriteLine(
                "banana2   == chocolate: " + (banana2 == chocolate));
            Console.WriteLine(
                "chocolate == banana:    " + (chocolate == banana));
            Console.ReadKey();
        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if (food1 == food2)
                Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
            else
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
        }
    }
}
