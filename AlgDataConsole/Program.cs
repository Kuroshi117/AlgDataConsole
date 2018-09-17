using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgDataConsole
{
    class Program
    {
        public static List<int> Numbers = new List<int>();
        public static List<Guid> GUIDs = new List<Guid>();
        public static List<double> Doubles = new List<double>();
        static Random rand = new Random();
        static void Main(string[] args)
        {
            AutoGenerate();
            Display(Numbers, GUIDs, Doubles);

            Console.ReadKey();
        }

       static public void AutoGenerate()
        {
            for(int i=0;i<1000001;i++)
            {
                Numbers.Add(i);
                GUIDs.Add(Guid.NewGuid());
                Doubles.Add(rand.Next());

            }
        }

        public static void Display(List<int> num, List<Guid> guid, List<double> db)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\workspace\FakeData.txt"))
            {
                for (int i = 0; i < num.Count; i++)
                {
                    sw.WriteLine(num[i].ToString() + ", " + guid[i].ToString() + ", " + db[i].ToString());

                }
            }
        }

    }
}


