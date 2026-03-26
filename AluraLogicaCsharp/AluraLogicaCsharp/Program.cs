namespace AluraLogicaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex5();
        }

        static void Ex1()
        {
            double[] doacoes = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int i;
            int sum;

            i = 0;
            sum = 0;
            while (i < doacoes.Length)
            {
                sum += (int) doacoes[i++];
            }

            Console.WriteLine($"A soma de todas as doações é {sum}");
        }

        static string Ex2()
        {
            int i;
            string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };
            Array.Sort(nomes);

            i = 0;
            while (i < nomes.Length)
            {
                Console.WriteLine($"Todos os nomes: {nomes[i++]}");
            }

            return nomes[2];
        }

        static string Ex3()
        {
            int[] numeros = {5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9};
            int i, j, k;

            i = 0;
            while (i < numeros.Length && numeros[i] != 19)
            {
                i++;
            }
            
            j = 0;
            while (j < numeros.Length + 1 && numeros[j] != 42)
            {
                j++;
            }
            
            k = 0;
            while (k < numeros.Length + 1 && numeros[k] != 7)
            {
                k++;
            }

            return $"Combinação do cadeado: {i}-{j}-{k}";
        }

        static void Ex4()
        {
            List<int> scores = new List<int>();
            
            scores.Add(150);
            scores.Add(90);
            scores.Add(200);
            scores.Add(120);
            scores.Add(150);
            scores.Add(80);
            scores.Add(180);
            scores.Add(200);

            scores.Sort();

            Console.WriteLine("Os scores ordenados são: ");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        static void Ex5()
        {
            List<string> codigos = new List<string>{"o", "d", "n", "u", "m", " ", "á", "l", "o"};
            codigos.Reverse();

            foreach (string codigo in codigos)
            {
                Console.WriteLine(codigo);
            }

        }
    }
}