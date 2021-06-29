using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveItATry give = new GiveItATry();
            //give.reverseTriangle();

            give.madeByAldi();
            //using (DataTable dt = new DataTable("Test"))
            //{
            //    dt.Columns.Add("ID", typeof(int));
            //    dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
            //    dt.Columns.Add("Dosage", typeof(int));
            //    dt.Columns.Add("Drug", typeof(string));
            //    dt.Columns.Add("Patient", typeof(string));
            //    dt.Columns.Add("Date", typeof(DateTime));

            //    dt.Rows.Add(1,1, "Indocin", "David", DateTime.Now);
            //    dt.Rows.Add(2,2, "Enebrel", "Sam", DateTime.Now);
            //    dt.Rows.Add(4,3, "damn", "you", DateTime.Now);
            //    dt.Rows.Add(7,4, "tigaroda", "semen", DateTime.Now);
            //    dt.Rows.Add(8,5, "soden", "pep", DateTime.Now);

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        Console.WriteLine("ID = {4}, Dosage = {0}, Drug = {1}, Patient = {2}, Date = {3}", dr["Dosage"], dr["Drug"], dr["Patient"], dr["Date"], dr["ID"]);
            //    }

            //    Console.ReadKey();
            //}



        }
    }
}


