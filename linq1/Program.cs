using System;
using System.Collections.Generic;
using System.Linq;


namespace linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            var um = new UniversityManager();
            
            // um.MaleStudents();
            // um.FemaleStudent();
            um.SortStudentByAge();
            System.Console.WriteLine("Select Univerity to see studentlist from it");
            foreach(var uni in um.universities)
            {
                System.Console.WriteLine($"{uni.Id}. {uni.Name}");
            }

            System.Console.WriteLine("choose index of the university");
            string index = Console.ReadLine();
            um.AllStudentfromUniversity(index);
            um.StudentAndUniversityNameCollection();

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
        public List<University> universities = new List<University>();
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
                    new Student{Id = 1, Name = "Carla", Gender="Female", Age = 27, UniversityId= 1},
                    new Student{Id = 2, Name = "Toni", Gender="male", Age = 21, UniversityId= 1},
                    new Student{Id = 3, Name = "Frank", Gender="male", Age = 22, UniversityId= 1},
                    new Student{Id = 4, Name = "Leyla", Gender="Female", Age = 19, UniversityId= 2},
                    new Student{Id = 5, Name = "James", Gender="trans-gender", Age = 25, UniversityId= 2},
                    new Student{Id = 6, Name = "Linda", Gender="Female", Age = 22, UniversityId= 2}
                }
            );
        }

        public void MaleStudents()
        {
            var maleStudents = from student in students where student.Gender=="male" select student;
            foreach(var student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudent()
        {
            var femaleStudents = from student in students where student.Gender=="Female" select student;
            foreach(var student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentByAge()
        {
            var studentList = from student in students orderby student.Age select student;
            foreach(var student in studentList)
            {
                student.Print();
            }
        }

        public void AllStudentfromUniversity(string id)
        {
            var iitStudentList =  from student in students
                                    where student.UniversityId.ToString() ==id
                                    select student; 
            if(iitStudentList.Count() >0)
            {
                foreach(var student in iitStudentList)
                {
                    student.Print();
                }
            }
            else
            {
                System.Console.WriteLine("No student present in the selected university");
            }
        }

        //create a new Collection from two tables
        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from x in students
                                join y in universities on x.UniversityId equals y.Id
                                orderby x.Name
                                select new {StudentName = x.Name, UniverityName= y.Name};
            System.Console.WriteLine("The result is ");
            foreach(var item in newCollection)
            {
                System.Console.WriteLine($"student name: {item.StudentName}, UinversityName: {item.UniverityName}");
            }

        }
    }
}
