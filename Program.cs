using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusokCucc {
    internal class Program {
        static void Main(string[] args) {
            // elso();
            // masodik();
            // harmadik();
            // negyedik();
            // otodik();
            // hatodik();
        }


        static void elso() {
            int n = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> numbers = Enumerable.Range(1, n);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", numbers.Reverse()));
        }

        static void masodik() {
            Random r = new Random();
            int d = Convert.ToInt32(Console.ReadLine());
            IEnumerable<int> dice = Enumerable.Range(1, d).Select(_ => r.Next(1, 7)).ToList();

            Console.WriteLine(string.Join(", ", dice));
            Console.WriteLine(dice.Count(i => i == 6));
        }

        static void harmadik() {
            List<char> mh = new List<char>{ 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ö', 'ő', 'ú', 'ü', 'ű' };
            string a = Console.ReadLine();
            int eCount = 0;
            int mhCount = 0;
            IEnumerable<char> letters = a.ToLower();

            eCount += letters.Count(i => i == 'e' || i == 'é');
            mhCount += letters.Count(i => mh.Contains(i));

            Console.WriteLine($"{((double) eCount / mhCount) * 100}%");
        }

        static void negyedik() {
            int n = Convert.ToInt32(Console.ReadLine());
            double limit = Math.Ceiling(Math.Sqrt(n));

            bool isPrim = !Enumerable.Range(2, (int) limit - 1).Any(i => n % i == 0);

            Console.WriteLine(isPrim ? "Prim" : "Osszetett");
        }

        static void otodik() {
            List<long> n = new List<long>();
            long a;

            do {
                a = Convert.ToInt64(Console.ReadLine());

                if (a > 0) n.Add(a);
            } while (a > 0);

            double atlag = (double) n.Sum() / n.Count;
            Console.WriteLine(atlag);
        }

        static void hatodik() {
            int a = Convert.ToInt32(Console.ReadLine());
            int f = 1; // 0-val való szorzás nem lehet ugyebár

            Enumerable.Range(1, a).ToList().ForEach(i => f *= i);

            Console.WriteLine(f);
        }

        static void hetedik() {

        }
    }
}
