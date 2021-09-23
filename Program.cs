using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            string saudacao = DateTime.Now.AddHours(-4).Hour > 12 ? "Boa tarde" : "Bom dia";
            Console.WriteLine(saudacao + " hora: " + DateTime.Now.AddHours(-4).Hour);

            saudacao = DateTime.Now.Hour > 12 ? "Boa tarde" : "Bom dia";
            Console.WriteLine(saudacao + " Hora: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);
            Console.WriteLine(saudacao + " Hora: " + DateTime.Now.ToShortTimeString());
            Console.WriteLine(saudacao + " Hora: " + DateTime.Now.ToString("HH:mm:ss"));


            int diaSemana;
            //exemplos switch case
            do
            {


                Console.Write("digite o dia da semana: ");
                if (int.TryParse(Console.ReadLine(), out diaSemana))
                {
                    switch (diaSemana)
                    {
                        case 1:
                            Console.WriteLine("Segunda");
                            break;
                        case 2:
                            Console.WriteLine("Terça");
                            break;
                        case 3:
                            Console.WriteLine("quarta");
                            break;
                        case 4:
                            Console.WriteLine("Quinta");
                            break;
                        case 5:
                            Console.WriteLine("Sexta");
                            break;
                        case 6:
                            Console.WriteLine("Sabado");
                            break;
                        case 7:
                            Console.WriteLine("Domingo");
                            break;
                        default:
                            Console.WriteLine("Dia invalido");
                            break;
                    }
                } 
            } while (true) ;

        }


    }
}
