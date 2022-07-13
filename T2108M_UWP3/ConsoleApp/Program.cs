using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product aa = new Product();
            while (true)
            {
                Console.WriteLine("\nChoose the function you want");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Add product records");
                            aa.addproduct();
                            Console.WriteLine(" successfully");
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Display product records");
                            aa.displayproduct(aa.getProduct());
                            break;
                        }
                    case 3:
                        {
                            string id;
                            Console.WriteLine("Delete product by Id");
                            Console.Write("\nNhap ID: ");
                            id = Console.ReadLine();
                            if (aa.deleteproduct(id))
                            {
                                Console.WriteLine("successfully", id);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exit");
                            return;
                        }
                    default:
                        break;
                }


            }
        }
    }
}
