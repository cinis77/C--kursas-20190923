using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataBaseFirst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ReadFromCSVFile();
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\EntityDataBaseFirst\EntityDataBaseFirst\DataBase.mdf;Integrated Security=True";
            Func<TestInformation, bool> delegatas = (x) => x.Supply == 503908;
            DataContext db = new DataContext(connectionString);
            var data = db.GetTable<TestInformation>()
                .Where(delegatas)
                .OrderByDescending((x) => x.Id);
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " "
                    + item.SensNo + " "
                    + item.Supply + " "
                    + item.TestSetups.First().B);
            }
        }

        private static void FilterDataBaseData(Func<TestInformation, bool> filter)
        {
        }

        private static void ReadFromCSVFile()
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader("testdata.csv"))
            {
                string line = null;
                bool firstLine = true;
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C--kursas-20190923\EntityDataBaseFirst\EntityDataBaseFirst\DataBase.mdf;Integrated Security=True";
                DataContext db = new DataContext(connectionString);
                var table = db.GetTable<TestInformation>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }
                    var splitData = line.Split(';');
                    TestInformation setObject = new TestInformation();
                    TestSetup setUpObject = new TestSetup();
                    int i = 0;
                    if (string.IsNullOrEmpty(splitData[i]))
                    {
                        continue;
                    }
                    setObject.RunSeq = Convert.ToInt32(splitData[i++]);
                    setObject.SensNo = splitData[i++];
                    if (string.IsNullOrEmpty(splitData[i]))
                    {
                        continue;
                    }
                    setObject.TestTemp = Convert.ToInt32(splitData[i++]);

                    setObject.Supply = Convert.ToInt32(splitData[i++].Replace(" ", ""));
                    setObject.Exposure = splitData[i++];
                    setObject.data = new DateTime(day: int.Parse(splitData[i].Split('/')[0]),
                        month: int.Parse(splitData[i].Split('/')[1]),
                        year: int.Parse(splitData[i++].Split('/')[2]));
                    setObject.Laikas = TimeSpan.Parse(splitData[i++]);
                    setObject.AirTemp = NumberExtractor(splitData[i++]);
                    setObject.Humidity = NumberExtractor(splitData[i++]);
                    setObject.Operator = splitData[i++];
                    setObject.Comment = splitData[i++];
                    i++;
                    setUpObject.A = double.Parse(splitData[i++]);
                    setUpObject.B = int.Parse(splitData[i++]);
                    setUpObject.C = int.Parse(splitData[i++]);
                    setUpObject.D = double.Parse(splitData[i++]);
                    setUpObject.E = int.Parse(splitData[i++]);
                    setUpObject.F = double.Parse(splitData[i++]);
                    i++;
                    setUpObject.MaxSupply = string.IsNullOrEmpty(splitData[i]) ? 0 : int.Parse(splitData[i++].Replace(" ", ""));
                    setUpObject.MinSupply = string.IsNullOrEmpty(splitData[i]) ? 0 : int.Parse(splitData[i++].Replace(" ", ""));
                    setObject.TestSetups.Add(setUpObject);
                    //db.GetTable<TestSetup>().InsertOnSubmit(setUpObject);
                    table.InsertOnSubmit(setObject);
                }
                db.SubmitChanges();
            }
        }

        private static int NumberExtractor(string word)
        {
            var array = word.ToCharArray();
            string digits = string.Empty;
            foreach (char item in array)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
            }
            return Convert.ToInt32(digits);
        }
    }
}