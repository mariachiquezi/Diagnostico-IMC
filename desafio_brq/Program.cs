using System;

namespace desafio_brq
{
    internal class Program
    {
        static void Main(string[] args)
        {    //variaveis usadas
            string nome, sexo, categoria = "", riscos = "", recomendacao="";
            double altura, peso, imc;
            int idade=0 ;
           
            //para o usuario inserir 
            Console.WriteLine("Insira seu nome:"); nome = Console.ReadLine();
            Console.WriteLine("Insira seu sexo:\n F-Feminino\n M-Masculino"); sexo = Console.ReadLine();
            Console.WriteLine("Insira sua idade:"); idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura:"); altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu peso:"); peso = double.Parse(Console.ReadLine());

            // calculo do imc 
            imc = peso / Math.Pow(altura, 2);
           
            //Resultado do diagostico
            Console.WriteLine("DIAGNOSTICO PREVIO");
            Console.WriteLine($"Nome: {nome}\nSexo: {MostrarSexo(ref sexo)}\nIdade: {idade}\nAltura: {altura}\nPeso: {peso}\nCategoria: {MostrarCategoria(ref categoria, idade)}\n\n\nResultado desejado: entre 20 e 24\n\nResultado IMC : {imc.ToString("F")}\n\nRiscos: {MostrarRiscos(ref imc, riscos)}\n\nRecomendacao: {MostrarRecomendacoes(ref imc, recomendacao)}");
           
        }

        //funçao feita a fim de deixar o codigo mais organizado
        // usei o operador ref no parametro e na chamada da funcao para fazer uma passagem por referencia 
        static string MostrarSexo( ref string sexo1) 
        {
            
            if (sexo1=="f" || sexo1== "F")
            {
               sexo1="Feminino";
            }
            else if (sexo1=="m" || sexo1=="M")
            {
                sexo1="Masculino";
            }
            return sexo1;
        }

        //funçao para Mostrar riscos feita a fim de deixar o codigo mais organizado
        // usei o operador ref no parametro e na chamada da funcao para fazer uma passagem por referencia 
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

        //função para mostrar a categoria
        // usei o operador ref no parametro e na chamada da funcao para fazer uma passagem por referencia 
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

        //funçãp para mostrar as recomendações 
        //segui o mesmo raciocinio das funções anteriores, usando o ref para fazer referencia
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
