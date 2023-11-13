using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Adicionais();
        }

        static void Guids()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("462bdca8-b2b1-4d00-8675-709ccd39230d");

            // if (id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0, 8));

        }

        static void Strings()
        {
            // Concatenação: junção de 2 ou mais "pedaços" EXEMPLOS:
            var price = 10.2;
            // var texto = "Preço do produto é: " + price + " -> apenas na promoção";
            // var texto = string.Format("O preço do produto é: {0} apenas na promoção", price);
            var texto = $"O preço do produto é {price} apenas na promoção";
            // var texto = "O preço do produto \n é: {price} apenas na promoção"; 
            // O \n quebra a linha ^^
            // var texto = $@"O preço do produto é:
            //              {price} apenas na promoção";

            Console.WriteLine(texto);

        }

        static void Comparação()
        {
            var texto = "Esse texto é um teste";
            // Console.WriteLine(texto.CompareTo("Testando"));
            // Console.WriteLine(texto.CompareTo("testando"));
            // CompareTo: Compara 2 strings iguais e retorna os números 1, 2 ou mais dependendo das palavras encontradas
            // Contains: Analisa se existe uma palavra dentro do texto e retorna True ou False (boolean)
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Contains(null));

        }

        static void StartsEnds()
        {
            var texto = "Este texto é um teste";
            // Esse método retorna um Booleano
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("xpro"));
        }

        static void Equals()
        {
            var texto = "Este texto é um teste";
            // Esse método retorna um Booleano
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        }

        static void Index()
        {
            var texto = "Este texto é um teste";
            // retorna a posição 
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void Adicionais()
        {
            var texto = "Este texto é um teste";
            // Converte o texto para minúsculo e maiúsculo
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            // Adiciona ou remove palavras no texto
            Console.WriteLine(texto.Insert(5, "AQUI "));
            Console.WriteLine(texto.Remove(5, 5));
            // Traz a quantidade de caracteres que a string tem
            Console.WriteLine(texto.Length);
            //  Troca as palavras dentro da string
            Console.WriteLine(texto.Replace("Este", "isto"));
            Console.WriteLine(texto.Replace("e", "X"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);
            // Trim serve para limpar os espaços do começo e do fim
            Console.WriteLine(texto.Trim());

            var texto1 = new StringBuilder();
            texto1.Append("Este texto é um teste");
            texto1.Append("é um teste");
            texto1.Append("Este texto");

            texto1.ToString();
            Console.WriteLine(texto1);


        }

    }
}