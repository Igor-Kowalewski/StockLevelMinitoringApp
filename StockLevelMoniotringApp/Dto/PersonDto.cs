using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Dto
{
    /// <summary>
    /// Data transfer object dla Person
    /// </summary>
   public class PersonDto
    {
        public int Id_people { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Pesel { get; set; }
        public int Job { get; set; }
    }
}
