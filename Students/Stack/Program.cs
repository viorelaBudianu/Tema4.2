using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private List<double> stack = new List<double>();
        private int rear;
        private int front;

        //constructor
        public Stack()
        {
            rear = 0;
            front = 0;
        }

        //metoda de adaugare in stiva
        public void Push()
        {
            Console.WriteLine("Introduceti numarul:");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Elementul {value} a fost adaugat;");
            stack.Add(value);


        }
        //metoda de eliminare din stiva
        public void Pop()
        {
            if (stack.Count < 1)
                Console.WriteLine("Stiva este goala!");
            else
            {
                Console.WriteLine($"De pe pozitia:{stack.Count} eliminam elementul {stack[stack.Count-1]}");
                stack.RemoveAt(stack.Count-1);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Coada are dimensiunea: {stack.Count}, si elementele sunt:");
            foreach (var a in stack)
            {
                Console.WriteLine(a);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Stack obj = new Stack();

            do
            {
                Console.WriteLine(" Stack Main Menu\n\n1.Insert \n2.Remove \n3.Display \n4. to exit\nEnter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.Push();
                        break;
                    case 2:
                        obj.Pop();
                        break;
                    case 3:
                        obj.Display();
                        break;
                }

            } while (choice != 4);
        }
    }
}
