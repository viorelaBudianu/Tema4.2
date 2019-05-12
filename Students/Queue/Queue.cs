using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private List<double> queue = new List<double>();
        private int rear;
        private int front;

        //constructor
        public Queue()
        {
            rear = 0;
            front = 0;
        }

        //metoda de adaugare in coada
        public void Enqueue()
        {
            Console.WriteLine("Introduceti numarul:");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Elementul {value} a fost adaugat;");
            queue.Add(value);


        }
        //metoda de eliminare din coada
        public void Dequeue()
        {
            if (queue.Count < 1)
                Console.WriteLine("Coada este goala!");
            else
            {
                Console.WriteLine($"De pe pozitia:{front} eliminam elementul {queue[front]}");
                front++;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Coada are dimensiunea: {queue.Count}, si elementele sunt:");
            foreach (var a in queue)
            {
                Console.WriteLine(a);
            }
        }

    }
}
