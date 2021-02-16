using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        public static void processInput(int tamanhoVendas, string vendas, int tamanhoVendedor, string vendedor)
        {
            var arrayVendas = converterEmVetor(vendas).Distinct().OrderByDescending(x => x).ToArray();
            var arrayVendedor = converterEmVetor(vendedor);

            int[] resultado = new int[tamanhoVendedor];

            if (arrayVendas.Length > tamanhoVendas || arrayVendedor.Length > tamanhoVendedor)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < arrayVendedor.Length; i++)
            {
                int posicao = 1;
                for (int j = 0; j < arrayVendas.Length; j++)
                {
                    if (arrayVendedor[i] >= arrayVendas[j])
                    {
                        posicao--;
                    }
                    else
                    {
                        posicao++;
                    }
                }

                resultado[i] = posicao;
            }

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }
        }

        public static int[] converterEmVetor(string vetor)
        {
            var arrayString = vetor.Split(" ");
            int[] novoVetor = new int[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
            {
                var valor = Convert.ToInt32(arrayString[i]);
                novoVetor[i] = Convert.ToInt32(arrayString[i]);
            }

            return novoVetor;
        }

        static void Main(string[] args)
        {
            string line;
            int tamanhoArrayVendas = 0;
            int tamanhoArrayVendedor = 0;
            string arrayVendas = string.Empty;
            string arrayVendedor = string.Empty;
            int indiceDados = 1;

            //while ((line = Console.ReadLine()) != null && indiceDados < 4)
            //{
            //    if (indiceDados == 1)
            //    {
            //        tamanhoArrayVendas = Convert.ToInt32(line);
            //    }

            //    if (indiceDados == 3)
            //    {
            //        tamanhoArrayVendedor = Convert.ToInt32(line);
            //    }

            //    if (indiceDados == 2)
            //    {
            //        arrayVendas = line;
            //    }

            //    if (indiceDados == 4)
            //    {
            //        arrayVendedor = line;
            //    }
            //    indiceDados++;

            //    Console.WriteLine(indiceDados);
            //}

            Console.WriteLine("RESULTADO: --------------");
            processInput(7, "55 100 100 40 100 50 35", 4, "20 60 40 10");
        }
    }
}
