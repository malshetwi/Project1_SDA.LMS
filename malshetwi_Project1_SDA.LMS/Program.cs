using System;

namespace malshetwi_Project1_SDA.LMS
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolFile school = new SchoolFile();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n:::::::::::::::::::::: Rainbow School System ::::::::::::::::::::::\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("> Rainbow School System for teachers data  [Store], [Retrieve] and [Update]\n");
            bool BoolValue = true;
            while (BoolValue)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n    <> Select service <> ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n [1] Add Teacher \n [2] Search for Teacher \n [3] Update Teacher informations \n [4] Exit");

                int? select = null;
                try
                {
                    Console.Write("                > ");
                    int SelectedService = int.Parse(Console.ReadLine());
                    select = SelectedService;
                }
                catch (Exception C0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n Wrong insert !!, put number");
                    
                }
                switch (select)
                {
                    case 1:

                        try
                        {
                            Console.Write("Enter ID : ");
                            int Id = int.Parse(Console.ReadLine());
                            Console.Write("Enter teacher Name : ");
                            string name = Console.ReadLine();
                            Console.Write("Class Name : ");
                            string _class = Console.ReadLine();
                            Console.Write("Section Name : ");
                            string section = Console.ReadLine();
                            school.AddNewItem(Id, name, _class, section);

                        }
                        catch (Exception C1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nPlease insert number in ID !!");

                        }




                        break;

                    case 2:
                        Console.Write("Insert the ID to Search > ");
                        int id_ToSearch = int.Parse(Console.ReadLine());
                        School teacherSearch = school.GetSchool(id_ToSearch);
                        if (teacherSearch != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(" > Teacher data has been Retrieved");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($" > ID:{teacherSearch.ID}\n > Name: {teacherSearch.Name}\n > Class: {teacherSearch.Class}\n > Section: {teacherSearch.section}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"\ninserted ID:{id_ToSearch} may be wrong try other one");
                        }
                        break;
                    case 3:
                        Console.Write("Insert the ID of teacher to Update > ");
                        int id_SearchToUpdate = int.Parse(Console.ReadLine());
                        School teacherUpdate = school.GetSchool(id_SearchToUpdate);
                        if (teacherUpdate != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(" > Teacher data retrieved To Update");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine($"> ID: {teacherUpdate.ID}\n> Name: {teacherUpdate.Name}\n> Class: {teacherUpdate.Class}\n> Section: {teacherUpdate.section}");
                            Console.WriteLine("\n> Insert the new informations : ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            int old_id = teacherUpdate.ID;
                            Console.Write("\n> Insert new ID : ");
                            int new_id = int.Parse(Console.ReadLine());
                            Console.Write("> Insert new Name : ");
                            string new_name = Console.ReadLine();
                            Console.Write("> Enter the new Class : ");
                            string new_class = Console.ReadLine();
                            Console.Write("> Enter the new Section : ");
                            string new_section = Console.ReadLine();
                            school.Update(old_id, new_id, new_name, new_class, new_section);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"\ninserted ID:{ id_SearchToUpdate} may be wrong try other one");
                        }
                        break;
                    case 4:
                        BoolValue = false;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n::::::::::::::::::::::::::::: Goodbye ::::::::::::::::::::::::::::: ");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" Choose from the four options:");

                        break;

                }
            }
        }
    }

}
