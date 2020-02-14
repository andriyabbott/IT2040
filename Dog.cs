using System;
namespace Dog
{
    public enum Gender {Male, Female};
    class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        /* constrctor */
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.age= age;
            this.owner= owner;
            this.gender= gender;
        }
        /*Bark stuff*/
        public void Bark(int times)
        {
            for(int i=0; i<times; i++)
            {
            Console.WriteLine("Woof!");
            }
            Console.WriteLine();
        }
        public string GetTag()
        {
            string tag= "If lost, call "+owner+" .";
            if (gender == 0)
            {
                tag += "His name is " + name+ " he is " + age.ToString();
            }
            else
            {
                tag += "Her name is " +name+ " she is " + age.ToString();
            }
            if (age >1)
            {
                tag += " year old.";
            }
            else 
            {
                tag += "year old.";
            }
            return tag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             /* Clss Dog*/
             Dog puppy= new Dog("Orion", "Shawn", 1 ,Gender.Male);
             puppy.Bark(3); /*Output should be Woof! Woof! Woof!*/
             Console.WriteLine(puppy.GetTag());

            Dog myDog= new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }

    }

}
