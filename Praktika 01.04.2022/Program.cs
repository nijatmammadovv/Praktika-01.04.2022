using System;
using Praktika_01._04._2022.Models;

namespace Praktika_01._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = " ";
            string email = " ";
            string password = " ";
            User users = new User("Email","Password","Fullname");
            Student student = new Student("Fullname",75);

            int choice = 0;
            do
            {
                Start:
                try
                {
                    Console.WriteLine("Choose the command (0:Info)");
                    Console.WriteLine("--------------");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You can use it to get information!");
                    goto Start;
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("----------------");
                        Console.WriteLine("1:ShowInfo\n" +
                            "2:Create new group\n" +
                            "3:Exit the program");
                        Console.WriteLine("----------------");
                        break;
                    case 1:
                        Console.WriteLine("----------------");
                        users.ShowInfo();
                        UserInformation(ref fullname, ref email, ref password);
                        Console.WriteLine("----------------");
                        break;
                    case 2:
                        Console.WriteLine("----------------");
                        Group group = new Group("AP205",18);
                        Console.WriteLine("----------------");
                        break;
                    default:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("User account information was entered incorrectly.");
                        Console.WriteLine("-----------------");
                        break;
                }
            } while (choice != 2);
            int key = 0;
            do
            {
                Console.WriteLine("----------------");
                Console.WriteLine("1.Show all students\n" +
                    "2.Get student by id\n" +
                    "3.Add student\n" +
                    "0.Quit");
                Console.WriteLine("----------------");
                Baslamaq:
                try
                {
                    Console.WriteLine("Choose the command (0:Info)");
                    Console.WriteLine("--------------");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Baslamaq;
                }
                switch (key)
                {
                    case 1:
                        Console.WriteLine("----------------");
                        student.StudentsInfo();
                        Console.WriteLine("----------------");
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        //StudentInformation(ref groupNo, ref _studentsLimit, ref point, ref id);
                        FullName(ref fullname);
                        //StudentPoint(ref point);
                        Student student1 = new Student(fullname,75);
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }

        static void UserInformation(ref string fullname, ref string email, ref string password)
        {
            FullName(ref fullname);
            Email(ref email);
            Password(ref password);
        }
        static void StudentInformation(ref string groupNo,ref int _studentsLimit, ref int point, ref int id)
        {
            GROUPNO(ref groupNo);
            StudentPoint(ref point);
            StudentLimit(ref _studentsLimit);
            Studentid(ref id);
        }
        static void FullName(ref string fullname)
        {
            Begin:
            try
            {
                Console.WriteLine("Enter the person's name");
                fullname = Convert.ToString(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Begin;
            }
        }
        static void Email(ref string email)
        {
            Initiate:
            try
            {
                Console.WriteLine("Enter the person's email");
                email = Convert.ToString(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Initiate;
            }
        }
        static void Password(ref string password)
        {
            GetStarted:
            try
            {
                Console.WriteLine("Enter the person's password");
                password = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetStarted;
            }
        }
        static void GROUPNO(ref string groupNo)
        {
            GROUPNO:
            try
            {
                Console.WriteLine("Enter the groupNo");
                groupNo =Convert.ToString(Console.ReadLine());;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GROUPNO;
            }
        }
        static void StudentLimit(ref int _studentsLimit)
        {
            StudentLimit:
            try
            {
                Console.WriteLine("Enter the number of students");
                _studentsLimit = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto StudentLimit;
            }
        }
        static void StudentPoint(ref int Point)
        {
            StudentPoint:
            try
            {
                Console.WriteLine("enter the point");
                Point = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto StudentPoint;
            }
        }
        static void Studentid(ref int id)
        {
            Studentid:
            try
            {
                Console.WriteLine("Enter the Id");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Studentid;
            }
        }
    }
}

