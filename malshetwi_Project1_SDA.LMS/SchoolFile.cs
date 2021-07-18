using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace malshetwi_Project1_SDA.LMS
{
    class SchoolFile
    {
        private readonly string path;
        StreamWriter writer;
        public SchoolFile()
        {
            path = @"C:\RainbowSchool.txt";

        }


        public void AddNewItem(int id, string name, string Class, string section)
        {
            writer = File.AppendText(path);
            string value = id + "-" + name + "-" + Class + "-" + section + "\n";
            writer.Write(value);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" > Teacher data has been Added");
            writer.Close();
        }


        public School GetSchool(int id)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string s in lines)
            {
                string[] line = s.Split("-");
                if (int.Parse(line[0]) == id)
                {
                    School school = new School(int.Parse(line[0]), line[1], line[2], line[3]);
                    return school;
                }

            }

            return null;
        }

        public void Update(int oldID, int id, string name, string Class, string section)
        {
            string[] lines = File.ReadAllLines(path);
            bool status = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split("-");
                if (int.Parse(line[0]) == oldID)
                {
                    lines[i] = id + "-" + name + "-" + Class + "-" + section;
                    status = true;
                }
            }
            if (status)
            {
                File.WriteAllLines(path, lines);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" > Teacher data has been Updated");
            }


        }


    }

}
