using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
start:      Console.Write("Enter\n 1. To add Teacher Details\n 2. To Update Teacher Details\n 3.Delete Details \n 4. To Display all Teacher Details\n");
            int a=Convert.ToInt32(Console.ReadLine());
            TeacherData teacherdata=new TeacherData();
            switch(a)
            {
                case 1:
                    Console.Write("Enter Teacher ID ");
                    int teacherID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Teacher's Name ");
                    string teacherName= Console.ReadLine();
                    Console.Write("Enter Teacher's Class and Section ");
                    string teacherClass= Console.ReadLine();
                   teacherdata.AddTeacherDetail(new Teacher { TeacherID = teacherID, TeacherName = teacherName, TeacherClass = teacherClass });
                    break;

                 case 2:

                    Console.WriteLine("Enter the ID to be updated");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter details for update, First with ID");
                    int ID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Teacher Name:");
                    string name1 = Console.ReadLine();
                    Console.Write("Enter Class and Section:");
                    string class1 = Console.ReadLine();
                    teacherdata.AddTeacherDetail(new Teacher { TeacherID = ID1, TeacherName = name1, TeacherClass = class1 });
                    teacherdata.RemoveTeacherDetail(ID);
                    break;
                    
                  case 3:
                    Console.WriteLine("Enter Teacher ID to delete the details");
                    int ID2 = Convert.ToInt32(Console.ReadLine());

                    teacherdata.RemoveTeacherDetail(ID2);
                    break;
  
                case 4:
                    teacherdata.DisplayTheDetails();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
            Console.WriteLine("Do you want to continue:(yes/no)?");
            string response= Console.ReadLine();
            if(response.ToLowerInvariant()=="yes")
            {
                goto start;
            }
            Console.ReadLine();
        }
    }
}
