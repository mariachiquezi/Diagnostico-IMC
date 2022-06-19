using System;

namespace desafio_brq
{
    internal class Program
    {
        static void Main(string[] args)
        {    //variaveis usadas
            string nome, sexo="", categoria = "", riscos = "", recomendacao="";
            double altura, peso, imc;
            int idade ;

            
            //para o usuario inserir 
            Console.WriteLine("Insira seu nome:"); nome = Console.ReadLine();
            Console.WriteLine("Insira seu sexo:\n F-Feminino\n M-Masculino"); Console.ReadLine();
           
            Console.WriteLine("Insira sua idade:"); int.TryParse(Console.ReadLine(), out idade);
            // do while usado para validar a idade
            //enquanto while for maior que 0 verificar se esta dentro dos criterios
            do
            {
                //if para verificar os criterios e entrar no while
                if (idade <= 1)
                {
                    while(idade<=1)
                    {
                        Console.WriteLine("Valor invalido, digite novamente:");
                        int.TryParse(Console.ReadLine(), out idade);
                    }
                }
                if(idade >=150)
                {
                    while (idade >= 150)
                    {
                        Console.WriteLine("Valor invalido, digite novamente:");
                        int.TryParse(Console.ReadLine(), out idade);
                    }
                }
                break;
            } while (idade >0);


            Console.WriteLine("Insira sua altura:");  double.TryParse(Console.ReadLine(),out altura);
            //do while usado para validar a altura 
            do
            {
                //if para verificar os criterios e entrar no while
                if (altura <= 1)
                {
                    while (altura <= 1)
                    {
                        Console.WriteLine("Valor invalido, digite novamente:");
                        double.TryParse(Console.ReadLine(), out altura);
                    }
                }
                if (altura >= 2.50)
                {
                    while (altura >= 2.50)
                    {
                        Console.WriteLine("Valor invalido, digite novamente:");
                        double.TryParse(Console.ReadLine(), out altura);
                    }
                }
                break;
            } while (altura > 0);

            Console.WriteLine("Insira seu peso:"); double.TryParse(Console.ReadLine(), out peso);
            //do while usado para validar o peso
            do
            {
                //if para verificar os criterios e entrar no while
                if (peso <= 1)
                {
                    while (peso <= 1)
                    {
                        Console.WriteLine("Valor invalido, digite novamente:");
                        double.TryParse(Console.ReadLine(), out peso);
                    }
                }
                if (peso >= 600)
                {
                    while (peso >= 600)
                    {
                        Console.WriteLine("Valor invalido, digite novamente:");
                        double.TryParse(Console.ReadLine(), out peso);
                    }
                }
                break;
            } while (peso > 0);

            // calculo do imc 
            imc = peso / Math.Pow(altura, 2);
           
            //Resultado do diagostico
            Console.WriteLine("DIAGNOSTICO PREVIO");
            Console.WriteLine($"Nome: {nome}\nSexo: {MostrarSexo(ref sexo)}\nIdade: {idade}\nAltura: {altura}\nPeso: {peso}\nCategoria: {MostrarCategoria(ref categoria, idade)}\n\n\nResultado desejado: entre 20 e 24\n\nResultado IMC : {imc.ToString("F")}\n\nRiscos: {MostrarRiscos(ref imc, riscos)}\n\nRecomendacao: {MostrarRecomendacoes(ref imc, recomendacao)}");
           
        }


        /// <summary>
        ///  feita a fim de deixar o codigo mais organizado e retornar o sexo,  usei o operador ref no parametro e na chamada da funcao para fazer uma passagem por referencia 
        /// </summary>
        /// <param name="sexo1">coletar o valor de sexo para retornar pro main</param>
        /// <returns>retorna o sexo1</returns>
        static string MostrarSexo( ref string sexo1) 
        {
            switch (sexo1)
            {
                case "f" :
                    sexo1 = "Feminino";
                    break;
                case "F":
                    sexo1 = "Feminino";
                    break;
                case "M":
                    sexo1 = "Masculino";
                    break;
                case "m":
                    sexo1 = "Masculino";
                    break;

            }
            return sexo1;
        }


       
        /// <summary>
        /// funçao para Mostrar riscos feita a fim de deixar o codigo mais organizado, usei o operador ref no parametro e na chamada da funcao para fazer uma passagem por referencia 
        /// </summary>
        /// <param name="imc">para comparar o imc com os valores dados </param>
        /// <param name="riscos">variavel para armazenar a mensagem(riscos)</param>
        /// <returns>retorna os riscos para mostrar a mensagem</returns>
        static string MostrarRiscos(ref double imc, string riscos)
        {
           
            if (imc <20)
            {
                riscos = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
            }
            if (imc >=20 && imc <= 24)
            {
                riscos = "Seu peso está ideal para suas referências.";
            }
            if (imc >= 25 && imc <= 29)
            {
               riscos = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
            }
            if (imc >= 30 && imc <= 35)
            {
                riscos = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade";
            }
            else if (imc > 35)
            {
                riscos = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas";
            }
            
           
            return riscos;
        }


        
        /// <summary>
        /// função para mostrar categoria, usei o operador ref no parametro e na chamada da funcao para fazer uma passagem por referencia 
        /// </summary>
        /// <param name="categoria">variavel para armazenar a mensagem(categoria)</param>
        /// <param name="idade">para comparar a idade com os valores dados</param>
        /// <returns>retorna a categoria</returns>
        static string MostrarCategoria(ref string categoria, int idade)
        {

            if (idade < 12)
            {
                categoria = "Infantil";
            }
            if (idade >= 12 && idade <= 20)
            {
                categoria = "Juvenil";
            }
            if (idade >= 21 && idade <= 65)
            {
                categoria = "Adulto";
            }
            else if (idade > 65)
            {
                categoria = "Idoso";

            }
            return categoria;
        }

        
        /// <summary>
        /// funçãp para mostrar as recomendações, segui o mesmo raciocinio das funções anteriores, usando o ref para fazer referencia
        /// </summary>
        /// <param name="imc">variavel feita para comparar o imc com os valores</param>
        /// <param name="recomendacao">para armazenar a mensagem(recomendações)</param>
        /// <returns>retorna a recomendação</returns>
        static string MostrarRecomendacoes(ref double imc, string recomendacao)
        {

            if (imc < 20)
            {
                recomendacao = " Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional.";
            }
            if (imc >= 20 && imc <= 24)
            {
                recomendacao = "Mantenha uma dieta saudável e faça seus exames periódicos.";
            }
            if (imc >= 25 && imc <= 29)
            {
                recomendacao = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante";
            }
            if (imc >= 30 && imc <= 35)
            {
                recomendacao = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
            }
            else if (imc > 35)
            {
                recomendacao = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médicoespecialista(endócrino).";
            }
            return recomendacao;
        }





    }
}
