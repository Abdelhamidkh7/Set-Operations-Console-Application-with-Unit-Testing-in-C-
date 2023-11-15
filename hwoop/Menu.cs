using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwoop
{
    public class Menu
    {
        private Set s = new Set();
        public Menu() { ; }
        public void Run()
        {
            int v;
            do
            {
                PrintMenu();
                v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1: Insert(); break;
                    case 2: Remove(); break;
                    case 3: SetEmpty(); break;
                    case 4: SetContains(); break;
                    case 5: RandomElement(); break;
                    case 6: Sum(); break;

                }
            }
            while (v != 0);
        }
        static private void PrintMenu()
        {
            Console.WriteLine("\n\n 0. - Quit");
            Console.WriteLine(" 1. - Insert an element");
            Console.WriteLine(" 2. - Remove an element");
            Console.WriteLine(" 3. - Set empty?");
            Console.WriteLine(" 4. - Set contains element? ");
            Console.WriteLine(" 5. - Get random element");
            Console.WriteLine(" 6. - Sum of elements");
            Console.Write(" Choose: ");
        }
    
        public void Insert()
        {
            try
            {
                Console.WriteLine("Type the Element: ");
                int a = int.Parse(Console.ReadLine());
                s.Addit(a);
            } catch(System.FormatException) 
            { Console.WriteLine("Number is expected!"); }
        }

        public void Remove()
        {
            try
            {
                Console.Write("Remove: ");
                int a = int.Parse(Console.ReadLine());
                s.Remove(a);
                Console.WriteLine(a+ " is removed from the set.");
            }
            catch (Set.ElementNotFoundException) 
            { Console.WriteLine("Element Not Found in the Set ");}
            catch (Set.EmptySetException) { Console.WriteLine("Set is Empty! Insert an element first"); }
        }
        public void SetEmpty()
        {

           if( s.IsEmpty())
                Console.WriteLine("The set is empty!");
            else Console.WriteLine("The set is not empty!"); 
        }
        public void SetContains()
        {
           
            Console.Write( "Enter Element: ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (s.Contains(a) == true)
                    Console.WriteLine("The set contains " + a);
                else Console.WriteLine("The set does not contain " + a);
            }
            catch(Set.EmptySetException)
            { Console.WriteLine("Set is Empty! Insert an element first"); }
        }
        public void RandomElement()
        {
            try
            {
                //int a = s.Random();
                Console.WriteLine(s.Random()  );
            }
            catch (Set.EmptySetException) 
            { Console.WriteLine("Set is Empty! Add Elements First"); }

        }
        public void Sum()
        {
            try
            {
                Console.WriteLine("The sum of elements is: " + s.Sum());
                //Console.WriteLine(s.Sum());
               
            }
            catch(Set.EmptySetException)
            { Console.WriteLine("Set is Empty! Insert an element first"   ); }

        }


    }
}
