using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Project1
{
    internal class TeacherData
    {
        public void AddTeacherDetail(Teacher detail)

        {
            string path = Environment.CurrentDirectory;
            FileInfo fileinfo = new FileInfo(path + "\\TeacherDetail.txt");
            using (StreamWriter streamWriter = new StreamWriter(fileinfo.FullName))
            {
                streamWriter.WriteLine($"{detail.TeacherID}\t{detail.TeacherName}\t{detail.TeacherClass}");
                streamWriter.Flush();
            }
        }
        public void RemoveTeacherDetail(int teacherID)
        {
            List<Teacher> details = new List<Teacher>();

                string path = Environment.CurrentDirectory;
                FileInfo fileinfo = new FileInfo(path + "\\TeacherDetail.txt");
                string[] lines = File.ReadAllLines(fileinfo.FullName);
                foreach (var line in lines)
                {
                    Teacher detail = new Teacher();
                    string[] values = line.Split('\t');
                    detail.TeacherID = Convert.ToInt32(values[0]);
                    detail.TeacherName = values[1];
                    detail.TeacherClass = values[2];
                    details.Add(detail);
                }
                if (details != null)
                {
                    var dataToDelete = details.Where(x => x.TeacherID == teacherID).FirstOrDefault();
                    details.Remove(dataToDelete);
                    fileinfo.Delete();
                    foreach (var detail in details)
                    {
                        AddTeacherDetail(detail);
                    }
                }
                
        }
            
        public void DisplayTheDetails()
        {
            string path = Environment.CurrentDirectory;
            FileInfo fileinfo = new FileInfo(path + "\\TeacherDetail.txt");
            string[] lines = File.ReadAllLines(fileinfo.FullName);
            foreach (var line in lines)
            {
                Console.WriteLine(line);


            }
        }
    }
}