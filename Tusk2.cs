using System;
using System.Collections.Generic;

namespace University
{
    class Program
    {
        static void Main()
        {
            UserInterface interfase = new UserInterface();
            Console.WriteLine("Enter name group:");
            string name = new string(Console.ReadLine());
            Group group = new Group(name);
            interfase.AddStudent(group);
            interfase.Info(group);
        }
    }

    abstract class Student
    {
        public string name;

        public string state;

        public Student(string name)
        {
            this.name = name;
            state = "";
        }

        protected void Relax()
        {
            state = state + "Relax ";
        }

        protected void Read()
        {
            state = state + "Read ";
        }

        protected void Write()
        {
            state = state + "Write ";
        }

        public abstract void study(); 
    } 
    
    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            state = "Good ";
        }
        public override void study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state = "Bad ";
        }

        public override void study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        public string nameGroup;

        public List<Student> students = new List<Student>();

        public Group(string nameGroup)
        {
            this.nameGroup = nameGroup;
        }



        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        
        public void GetInfo()
        {
            Console.WriteLine(nameGroup);
            foreach (Student stnt in students)
            {
                Console.WriteLine(stnt.name);
            }
        }

        public void GetFullInfo()
        {
            Console.WriteLine(nameGroup);
            foreach (Student stnt in students)
            {
                Console.WriteLine(stnt.name + ": " + stnt.state);
            }
        }
    }

    class UserInterface
    {   
        public void AddStudent(Group g)
        { 
            bool flag = true;
            while (flag) { 
                Console.WriteLine("To add a student, enter name");
                string n = Console.ReadLine();
                Console.WriteLine("Enter good and bad");
                if (Console.ReadLine() == "good")
                {
                    GoodStudent sg = new GoodStudent(n);
                    sg.study();
                    g.AddStudent(sg);
                }
                else
                {
                    BadStudent sb = new BadStudent(n);
                    sb.study();
                    g.AddStudent(sb);
                }
                Console.WriteLine("Contine adding? Yes(1) No(2)");
                if(Console.ReadLine() == "1")
                {

                }
                else
                {
                    flag = false;
                }
            }
        }

        public void Info(Group g)
        {
            Console.WriteLine("Clicl 1(Info) or 2(FullInfo)");
            if(Console.ReadLine() == "1")
            {
                g.GetInfo();
            }
            else
            {
                g.GetFullInfo();
            }
        }
    }
}    
