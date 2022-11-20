using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classInterihance2.Models
{
    internal class Group
    {
        public string GroupName;
        public Student[] Students;

        public Group(string GroupName)
        {
            this.GroupName = GroupName;
            Students = new Student[0];
            Array.Resize(ref Students, 6);
        }
        public static void Add(Student[] Students)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, Students[i]);
            }
            Console.WriteLine();
        }
        public static void GetAll(string name,string surname)
        {
            Console.WriteLine(name+surname);
        }
        public static void GetOnlineStudents()
        {
            bool isOnline = true;
            Console.WriteLine();
        }
        public static void GetOfflineStudents()
        {
            bool isOnline = false;
            Console.WriteLine();
        }
    }
}
