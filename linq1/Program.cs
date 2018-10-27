using System;
using System.Collections.Generic;
using System.Linq;


namespace linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{1, 2, 3,  4, 5, 6 ,7, 8, 9, 10, 1, 11, 12};
            oddNumbers(numbers);
            Console.ReadKey();
        }

        static void oddNumbers(int[] num)
        {
            Console.WriteLine("Odd numbers:");
            var oddNumbers = from number in num where number %2 != 0 select number;
            Console.WriteLine(string.Join(",", oddNumbers));
        }
    }

    class  University
    {
        public int Id { get; set; } 
        public string Name { get; set; }    

        public void Print()
        {
            Console.WriteLine(@"University {id} with {Name}");
        }
    }

    class Student
    {
        public int Id{get; set;}
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine($"Student {Name} with id {Id}, Gender {Gender} and Age {Age} from University with Univerity ID {UniversityId}");
     }
    }

    class UniversityManager{
        List<University> universities = new List<University>();
        List<Student> students = new List<Student>();
        public UniversityManager()
       {
            universities.AddRange(
                new List<University>{
                new University{Id = 1, Name="Yale"},
                new University{Id = 2, Name = "IIT"}
                });
            students.AddRange(
                new List<Student>(){
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1}
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1}
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1}
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1}
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1}
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1}
                }
            )
        }


    }

}
