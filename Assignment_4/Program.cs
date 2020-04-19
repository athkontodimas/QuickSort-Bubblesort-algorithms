using Assignment_4.Database;
using Assignment_4.Entities;
using Assignment_4.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDatabase db = new MyDatabase();

            //======================================Linq (default=quicksort)=====================================

            //var shirts = db.Shirts.OrderBy(x => x.Color).ToList();
            //var shirts = db.Shirts.OrderBy(x => x.Size).ToList();
            //var shirts = db.Shirts.OrderBy(x => x.Fabric).ToList();
            //var shirts = db.Shirts.OrderByDescending(x => x.Fabric).ToList();
            //var shirts = db.Shirts.OrderBy(x => x.Size).ToList();
            // var shirts = db.Shirts.OrderBy(x => x.Color).ThenBy(x=>x.Size).ThenBy(x=>x.Fabric).ToList();

            //PrintAllItems(db.Shirts); 

            // PrintAllItems(shirts); //me linq


           
          //================QuickSort===========================================

            var shirts = db.Shirts.ToArray();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Color Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.ColorAsc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Color Descending");
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.ColorDesc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Size Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.SizeAsc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Size Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.SizeDesc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fabric Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.FabricAsc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fabric Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.FabricDesc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);




            //--------------------------------------------------BubbleSort-----------------------------------------------
            //Shirt[] arr = db.Shirts.ToArray();

            //[] arr1 = { new Int32(), new Int32(), new Int32(), new Int32(), new Int32(), new Int32() }; // πίνακας από αντικειμενα ιντ32 


            var shirts1 = db.Shirts;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort SizeColorFabric Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeColorFabricAsc2(shirts1);
            PrintAllItems(shirts1);


            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
          //  BubbleSort.SizeColorFabricAsc(shirts1);
            Console.WriteLine("BubbleSort SizeColorFabric Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeColorFabricDesc2(shirts1);
           // BubbleSort.SizeColorFabricDesc(shirts1);
            PrintAllItems(shirts1);


            
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort Color Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.ColorAsc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort Color Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.ColorDesc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort Size Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeAsc(shirts1);
            PrintAllItems(shirts1);
            
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort Size Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeDesc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort Fabric Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.FabricAsc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("BubbleSort Fabric Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.FabricDesc(shirts1);
            PrintAllItems(shirts1);
        }



        public static void PrintAllItems(IEnumerable<Shirt> shirts)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("All Clothes");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Color", "Size", "Fabric");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in shirts)
                {
                    item.Output();
                }
            }
        
    }
}
    

