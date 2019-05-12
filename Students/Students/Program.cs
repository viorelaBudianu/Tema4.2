using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Students
{


        class Program
        {
            static void Main(string[] args)
            {
                Exercitiul3StudentiMuncitori();
               

            }

            
            private static void Exercitiul3StudentiMuncitori()
            {
                List<Students> studenti = new List<Students>();
                Students s1 = new Students("Anton", "Maria", 9);

                //Console.Write(s1.FirstName+s1.LastName+s1.Grade);
                studenti.Add(s1);
                studenti.Add(new Students("Budianu", "Alexandru", 8.5));
                studenti.Add(new Students("Hariga", "Viorela", 9.3));
                studenti.Add(new Students("Popescu", "Ion", 5.1));
                studenti.Add(new Students("Aciobanitei", "Andreea", 8.7));
                studenti.Add(new Students("Burlacu", "Lavinia", 10));
                studenti.Add(new Students("Ionescu", "Vasile", 7));
                studenti.Add(new Students("Vasilescu", "George", 8.7));
                studenti.Add(new Students("Altica", "Mihai", 4.3));
                studenti.Add(new Students("Ionescu", "Ana", 7.9));
                foreach (var a in studenti)
                {
                    Console.WriteLine($"{a.FirstName} {a.LastName} - {a.Grade}");
                }
                Console.WriteLine("---------------Studenti ordonati dupa nota-------------------------");
                var ordonati = studenti.OrderBy(x => x.Grade).ToList<Students>();
                foreach (var a in ordonati)
                {
                    Console.WriteLine($"{a.FirstName} {a.LastName} - {a.Grade}");
                }

                List<Workers> muncitori = new List<Workers>();
                muncitori.Add(new Workers("Ionescu", "George", 840, 6));
                muncitori.Add(new Workers("Popescu", "Lucian", 590.0, 7));
                muncitori.Add(new Workers("Vasilescu", "Andrei", 478, 4));
                muncitori.Add(new Workers("Codrescu", "Marin", 540, 6));
                muncitori.Add(new Workers("Maxim", "George", 101.90, 1));
                muncitori.Add(new Workers("Nica", "Ioana", 983.3, 4));
                muncitori.Add(new Workers("Iftime", "Ana", 589.70, 3));
                muncitori.Add(new Workers("Grecu", "Mircea", 687.40, 6));
                muncitori.Add(new Workers("Fronea", "Alexandra", 435.5, 5));
                muncitori.Add(new Workers("Ionescu", "Ion", 1540, 8));

                Console.WriteLine("---------------Muncitori-------------------------");
                foreach (var m in muncitori)
                {
                    Console.WriteLine($"{m.FirstName} {m.LastName} -Week Salary: {m.WeekSalary} ->{m.MoneyPerHour(m.WeekSalary, m.WorkHoursPerDay)} Money per hour (Working hours:{m.WorkHoursPerDay})");
                }

                var MuncitoriOrdonati = muncitori.OrderByDescending(x => x.MoneyPerHour(x.WeekSalary, x.WorkHoursPerDay)).ToList<Workers>();
                Console.WriteLine("---------------Muncitori ordonati dupa MoneyPerHour-------------------------");
                foreach (var m in MuncitoriOrdonati)
                {
                    Console.WriteLine($"{m.FirstName} {m.LastName} - {m.MoneyPerHour(m.WeekSalary, m.WorkHoursPerDay)}");
                }

                List<Humans> Oameni = new List<Humans>();
                Oameni.AddRange(studenti);
                Oameni.AddRange(muncitori);
                Console.WriteLine("--------------------------Toti Oamenii-------------------");
                foreach (var o in Oameni)
                {
                    Console.WriteLine($"Nume:{o.LastName}; Prenume:{o.FirstName}");
                }

                var OameniAranjati = Oameni.OrderBy(x => x.LastName).ThenBy(y => y.FirstName);
                Console.WriteLine("--------------------------Oameni Aranjati-------------------");
                foreach (var om in OameniAranjati)
                {
                    Console.WriteLine($"Nume:{om.LastName}; Prenume:{om.FirstName}");
                }
            }
        }
    }

