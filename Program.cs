using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        { //Declaring variables
            int[] a = new int[5];
            int x = 0;
           
            //Requesting data from the user
            Console.Write(" Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            a[0] = x;
            
            Console.Write(" Enter the second number: ");
            x = Convert.ToInt32(Console.ReadLine());
            a[1] = x;
            
            Console.Write(" Enter the third number: ");
            x = Convert.ToInt32(Console.ReadLine());
            a[2] = x;
           
            Console.Write(" Enter the fourth number: ");
            x = Convert.ToInt32(Console.ReadLine());
            a[3] = x;

            Console.Write(" Enter the fifth number: ");
            x = Convert.ToInt32(Console.ReadLine());
            a[4] = x;
            
            if((a[0] + a[1]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0],a[1]);
            }
            if ((a[0] + a[2]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0],a[2]);
            }           
            if ((a[0] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0],a[3]);
            }
            if ((a[0] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0],a[4]);
            }
            if ((a[0] + a[1] + a[2]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0],a[1], a[2]);
            }
            if ((a[0] + a[1] + a[2] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} + {8} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[1], a[2], a[3]);
            }
            if ((a[0] + a[1] + a[2] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} + {8} + {9} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[1], a[2], a[3], a[4]);
            }
            if ((a[0] + a[1] + a[2] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} + {8}  = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[1], a[2], a[4]);
            }
            if ((a[0] + a[1] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[1], a[3]);
            }
            if ((a[0] + a[1] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} + {8}  = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[1], a[3], a[4]);
            }
            if ((a[0] + a[1] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[1], a[4]);
            }
            if ((a[0] + a[2] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[2], a[3]);
            }
            if ((a[0] + a[2] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} + {8}  = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[2], a[3], a[4]);
            }
            if ((a[0] + a[2] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[2], a[4]);
            }
            if ((a[0] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0], a[3], a[4]);
            }
            if ((a[1] + a[2]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1],a[2]);
            }
            if ((a[1] + a[2] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1], a[2], a[3]);
            }
            if ((a[1] + a[2] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} + {8} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1], a[2], a[3], a[4]);
            }
            if ((a[1] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1], a[3]);
            }
            if ((a[1] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1], a[3], a[4]);
            }
            if ((a[1] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1], a[4]);
            }
            if ((a[1] + a[2] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1], a[2], a[4]);
            }
            if ((a[2] + a[3]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[2], a[3]);
            }
            if ((a[2] + a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set{0}, {1}, {2}, {3}, {4} the subset {5} + {6} + {7} = 0 ", a[0], a[1], a[2], a[3], a[4], a[2], a[3], a[4]);
            }
            if ((a[2] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[2], a[4]);
            }
            if ((a[3] + a[4]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[3], a[4]);
            }
            if ((a[0]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[0]);
            }
            if ((a[1]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[1]);
            }
            if ((a[2]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[2]);
            }
            if ((a[3]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[3]);
            }
            if ((a[4]) == 0)
            {
                Console.WriteLine(" In the number set {0}, {1}, {2}, {3}, {4} the subset {5} + {6} = 0 ", a[0], a[1], a[2], a[3], a[4], a[4]);
            }

            Console.ReadKey();
        
        }
    }
}
