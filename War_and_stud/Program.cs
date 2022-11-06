using System;
namespace ConsoleApp16
{
    public class Human
    {
        public string Fio { get; set; }
        public int Age { get; set; }
        public Human(string fio, int age)
        {
            Fio = fio;
            Age = age;
        }
        public virtual void Print()
        {
            Console.WriteLine(Fio + " " + Age);
        }
        class Student : Human
        {
            public string Spec { get; set; }
            public int Kurs { get; set; }
            public int Group { get; set; }
            public Student(string spec, int kurs, int group, string fio, int age) : base(fio, age)
            {
                Spec = spec;
                Kurs = kurs;
                Group = group;
            }
            public override void Print()
            {
                Console.WriteLine(Spec + " " + Kurs + " " + Group + " " + base.Fio + " " + base.Age);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Human a = new Human("Tit", 7);
                Student b = new Student("Programmist", 3, 520, "Tit", 7);
                a.Print();
                b.Print();

            }
        }
    }
}
