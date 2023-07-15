using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace JramirezS7
{
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement]
        public int id {  get; set; }
        [MaxLength(225)]

        public string nombre { get; set; }
        [MaxLength(225)]

        public string usuario { get; set;}
        [MaxLength(225)]

        public string contresena { get; set;}
    }

  
}
