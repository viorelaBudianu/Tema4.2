using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    

        class Program
        {
            static void Main(string[] args)
            {
                Queue();
            }
            private static void Queue()
            {
                int choice;
                Queue obj = new Queue();

                do
                {
                    Console.WriteLine(" Queue Main Menu\n\n1.Insert \n2.Remove \n3.Display \n4. to exit\nEnter Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            obj.Enqueue();
                            break;
                        case 2:
                            obj.Dequeue();
                            break;
                        case 3:
                            obj.Display();
                            break;
                    }

                } while (choice != 4);
            }

        }
    }

