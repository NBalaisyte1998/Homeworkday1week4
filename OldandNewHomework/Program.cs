using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace OldandNewHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat catone = new Cat("Tibbie", 2);
            methods.CatAge(catone);
            methods.CatAge(catone);
           
            Console.Read();
        }
    }
    class Cat
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
    class methods
    {
        public static object CatAge(Cat cat)
        {
            cat.Age = cat.Age + 5;
            return cat;
        }
    }
}
