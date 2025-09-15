using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CiklusokCucc {
    internal class Program {
        static void Main(string[] args) {
            // masodik();
            // harmadik();
            // negyedik();
            // otodik();
            // hatodik();
            // hetedik();
            // nyolcadik();
        }

        // BM KÉSZ!
        static void elso() {
            var sb = new StringBuilder();
            int n = 100;

            for (int i = 1; i <= n; i++) {
                if (i > 1) sb.Append(", ");
                sb.Append(i);
            }

            for (int i = n; i >= 1; i--) {
                sb.Append(", ");
                sb.Append(i);
            }

            Console.WriteLine(sb.ToString());
        }

        // BM KÉSZ!
        static void masodik() {
            Random r = new Random();
            int d = 100;
            var dice = new List<int>(d);

            for (int i = 0; i < d; i++) {
                dice.Add(r.Next(1, 7));
            }

            Console.WriteLine(string.Join(", ", dice));
            Console.WriteLine(dice.Count(i => i == 6));
        }

        // BM KÉSZ!
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

        // BM KÉSZ!
        static void negyedik() {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 2) Console.WriteLine("Osszetett");
            if (n == 2) Console.WriteLine("Prim");
            if (n % 2 == 0) Console.WriteLine("Osszetett");

            int limit = (int)Math.Sqrt(n);

            for (int i = 3; i <= limit; i += 2) {
                if (n % i == 0) Console.WriteLine("Osszetett");
            }

            Console.WriteLine("Prim");
        }

        // BM KÉSZ!
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

        // BM KÉSZ!
        static void hatodik() {
            int a = Convert.ToInt32(Console.ReadLine());
            int f = 1; // 0-val való szorzás nem lehet ugyebár

            for (int i = 1; i <= a; i++) {
                f *= i;
            }

            Console.WriteLine(f);
        }

        // Nem kell BM
        static void hetedik() {
            int f;

            do {
                f = Convert.ToInt32(Console.ReadLine());
            } while (f <= 1940 || f >= 2020);

            Console.WriteLine(2020 - f);
        }

        static void nyolcadik() {
            string m = "1 - Add meg a nevet\n2 - Üdv {0}!\n3 - Helló {0}!\n4 - Szia {0}!\n5 - Kilépés.";
            string n = "";
            bool running = true;

            while (running) {
                Console.WriteLine(m);
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a) {
                    case 1:
                        n = Console.ReadLine();
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(n)) {
                            Console.WriteLine(m);
                            break;
                        }

                        Console.WriteLine($"Üdv {n}");
                        break;
                    case 3:
                        if (string.IsNullOrEmpty(n)) {
                            Console.WriteLine(m);
                            break;
                        }

                        Console.WriteLine($"Hello {n}");
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(n)) {
                            Console.WriteLine(m);
                            break;
                        }

                        Console.WriteLine($"Szia {n}");
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine(m);
                        break;
                }
            }
        }

        static void kilencedik() {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i * i <= n; i++) { // nem kell minden számot megnézni csak a gyök(n)-ig mivel ha i osztja n-t akkor n / i is osztó.
                if (n % i == 0) {
                    if (i * i == n) count += 1;
                    else count += 2;
                }
            }

            Console.WriteLine(count);
        }

        static long lcm(int x, int y, int gcd) {
            return ((long) x * y) / gcd;
        }

        static int gcd(int a, int b) {
            while (b != 0) {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static void tizedik() {
            int a = gcd(6, 10);

            Console.WriteLine($"{a} {lcm(6, 10, a)}");
        }

        static void tizenegyedik() {
            int x = 100;

            if (x == 1) {
                Console.WriteLine(1);
                return;
            }

            List<string> factors = new List<string>();
            int original = x;

            while (x % 2 == 0) { // csak gyökig iterál, ha a szám összetett biztos van EGY primosztoja ami legfeljebb a gyökével egyenlő
                factors.Add("2");
                x /= 2;
            }

            for (int i = 3; i <= x * x; i += 2) { // 2-esével lép mivel a párosokat már kiszűrtük!
                while (x % i == 0) {
                    factors.Add(i.ToString());
                    x /= i;
                }
            }

            if (x > 1) { // ha a maradék nagyobb mint 1 az maga is prim!
                factors.Add(x.ToString());
            }

            Console.WriteLine(string.Join("*", factors));
        }

        static void tizenkettedik() {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int K = int.Parse(input[2]);

            for (int x = 0; x <= K / N; x++) {
                int remainingHeads = K - N * x;

                if (remainingHeads >= 0 && remainingHeads % M == 0) {
                    int y = remainingHeads / M;
                    Console.WriteLine($"{x} {y}");
                    return;
                }
            }

            Console.WriteLine("0 0");
        }

        static void tizenharmadik() {
            long n = long.Parse(Console.ReadLine());

            if (n < 0) {
                Console.WriteLine(0);
                return;
            }

            if (n == 0) {
                Console.WriteLine(1);
                return;
            }

            long a = 0; // F0
            long b = 1; // F1
            int index = 1; // F1 i

            while (b <= n) {
                long next = a + b;
                a = b;
                b = next;
                index++;
            }

            Console.WriteLine(index);
        }

        static void tizennegyedik() {
            int n = int.Parse(Console.ReadLine());

            if (n <= 0) {
                return;
            }

            // növekvő
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(new string('*', i));
            }

            Console.WriteLine();

            // 2. növekvő, eltolva
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(new string(' ', n - i) + new string('*', i));
            }

            Console.WriteLine();

            // csökkenő, eltolva
            for (int i = n; i >= 1; i--) {
                Console.WriteLine(new string(' ', n - i) + new string('*', i));
            }

            Console.WriteLine();

            // csökkenő
            for (int i = n; i >= 1; i--) {
                Console.WriteLine(new string('*', i));
            }

            Console.WriteLine();

            // Piramis: 2N hosszúságú
            for (int i = 1; i <= 2 * n; i += 2) { // 1-től indul és 2-vel nő, és addig megy amig i != 2 * n (a legnagyobb sorban 2 * n - 1 * lesz!)
                int spaces = (2 * n - i) / 2; // hány szóköz kell, piramis alapja -> (2 * n - 1) / 2
                Console.WriteLine(new string(' ', spaces) + new string('*', i) + new string(' ', spaces));
            }
        }
    }
}
