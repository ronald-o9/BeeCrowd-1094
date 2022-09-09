namespace exercicios
{

     class Program
    {
        static void Main(String[] args)
        {

            int N, Quantia, C, R, S, Total;
            char Tipo;
            double percent_coelho, percent_sapo, percent_rato;

            N = int.Parse(Console.ReadLine());

            Quantia = 0;
            Total = 0;
            C = 0;
            R = 0;
            S = 0;
            for (int i = 1; i <= N; i ++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                Quantia = int.Parse(vetor[0]);
                Tipo = char.Parse(vetor[1]);

                Total += Quantia;
                if (Tipo == 'C')
                {
                    C += Quantia;
                }

                if (Tipo == 'S')
                {
                    S += Quantia;
                }

                if (Tipo == 'R')
                {
                    R += Quantia;
                } 
             
               
            }

            percent_coelho = (100.0 * C) / Total;
            percent_rato = (100.0 * R) / Total;
            percent_sapo = (100.0 * S) / Total;

            Console.WriteLine("Total: " + Total + " cobaias");
            Console.WriteLine("Total de coelhos: " + C);
            Console.WriteLine("Total de ratos: " + R);
            Console.WriteLine("Total de sapos: " + S);
            Console.WriteLine("Percentual de coelhos: " + percent_coelho.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + percent_rato.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + percent_sapo.ToString("F2") + " %");


        }
    }
}