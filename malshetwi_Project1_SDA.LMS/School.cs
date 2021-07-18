using System;
using System.Collections.Generic;
using System.Text;

namespace malshetwi_Project1_SDA.LMS
{
    class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string section { get; set; }

        public School(int id, string name, string clas, string section)
        {
            this.ID = id;
            this.Class = clas;
            this.section = section;
            this.Name = name;
        }

    }

}
