using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;
using System.Xml;
using System.IO;
using System.Data.SQLite;


namespace TestForGAZIT
{
    static class Program
    {
  
        public class Division
        {
            public int id { get; set; }
            public int division_id { get; set; }
            public string div_name { get; set; }

        }
        public class Personal
        {
            //[PrimaryKey, AutoIncrement, Unique]
            public int id { get; set; }

            //[MaxLength(30), NotNull]
            public string FirstName { get; set; }

            //[MaxLength(30)]
            public string SecondName { get; set; }

            //[MaxLength(30), NotNull]
            public string LastName { get; set; }

            //[NotNull]
            public DateTime BirthDate { get; set; }

            //[Ignore]
            public string FullName
            {
                get
                {
                    return string.Format(
                        "{0} {1} {2}",
                        LastName,
                        FirstName,
                        SecondName
                    );
                }
            }

            public override string ToString()
            {
                return string.Format(
                    "{0}: {1} {2}",
                    id,
                    FullName,
                    BirthDate.ToString("dd-MM-yyyy")
                );
            }
        }

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


    }

}
