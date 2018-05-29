using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachka1
{
    class Program
    {
        static Animal[] animal_array = new Animal[5];
        static void Main(string[] args)
        {
           
            animal_array[0] = new Dog("Sharik");
            animal_array[1] = new Dog("Brovko");
            animal_array[2] = new Cat("Murchik");
            animal_array[3] = new Parrot("Kesha");
            animal_array[4] = new Cenery("Cenery");
            //Animal[] birds = GetAnimal(typeof(Bird));
            foreach(Animal el in animal_array)
            {
                el.Voice();
                el.AddAge(IReadOnlyCollection.)
            }

        }
        public static Animal GetAnimal(Type animalType)
        {
            int count = 0;
            foreach (Animal element in animal_array)
            {
                if(element.GetType() == animalType)
                {
                    count++;
                }
            }
            foreach (Animal element in animal_array)
            {
                if (element.GetType() == animalType)
                {
                    count++;
                }
            }
            Animal[] animal_arr = new Animal[count];
            for (int i=0;i<count;i++)
            {
                Animal element = animal_array[i];
                if(element.GetType() == animalType)
                {
                    animal_arr = animal_array;
                }
            }
        }

    }
}
