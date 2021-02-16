using System;

namespace App.Provas
{
    public static class RaizQuadrada
    {
        public static string processInput(string input)
        {
            var valorConvertido = Int32.Parse(input);
            var resultado = ObterRaiz(valorConvertido);
            return Math.Round(resultado, 3).ToString();
        }
        public static int ObterNumeroAproximado(int raiz)
        {
            var result = 0;

            for (int i = 0; i < raiz; i++)
            {
                var valorQuadrado = i * i;
                if (valorQuadrado < raiz)
                {
                    result = i;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public static double ObterRaiz(int valor)
        {
            var disma = 0.00001;
            double numeroAproximado = ObterNumeroAproximado(valor);

            if (numeroAproximado * numeroAproximado == valor)
            {
                return numeroAproximado;
            }

            while (numeroAproximado < valor)
            {
                if (numeroAproximado * numeroAproximado >= valor)
                {
                    break;
                }

                numeroAproximado += disma;
            }

            return numeroAproximado;
        }
    }
}
