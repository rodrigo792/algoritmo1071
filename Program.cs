namespace algoritmo1071
{
    class Programa
    {
        static void Main(string[] args)
        {

            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[6]);

  
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            int soma = 0;

            // Somar os números ímpares entre X e Y
            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            // Exibir a soma dos números ímpares
            Console.WriteLine(soma);
        }
    }
}
