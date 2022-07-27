using System;

namespace Operacoes_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day); // Retorna o dia
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour); // Retorna a hora
            Console.WriteLine("6) Kind: " + d.Kind); // Tipo do DateTime - Se é local ou universal
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);//Retorna o minuto
            Console.WriteLine("9) Month: " + d.Month);//Retonra o mês
            Console.WriteLine("10) Second: " + d.Second);//Retorna os segundos
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); // Horário do dia
            Console.WriteLine("13) Year: " + d.Year); // Retorna o Ano

            Console.WriteLine("Apenas a Hora atual: " + d1.Hour);
            Console.WriteLine("Dia de hoje no mês: " + d1.Day);


            //Formatação de Datas 


            Console.WriteLine(d1.ToLongDateString()); // Data Atual em formato completo
            Console.WriteLine(d1.ToShortDateString()); // Data Atual em formato reduzido
            Console.WriteLine(d1.ToLongTimeString()); // Hor, minuto e segundo Atual 
            Console.WriteLine(d1.ToShortTimeString()); // Hora e minuto atuais
            Console.WriteLine(d1.ToString()); // Data e hora local
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss")); // Formatando manualmente a data e hora
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff")); // Formatando manualmente a data e hora com milisegundos



            // Operação com Datas

            Console.WriteLine(d1.AddMinutes(3)); // Adiciona 3 minutos ao d1;
            Console.WriteLine(d1.AddHours(2));// Adiciona 2 Horas ao d1;

            Console.WriteLine("-----------------");
            DateTime d3 = new DateTime(2022,07,26,23,50,10);

            Console.WriteLine(d3);

            TimeSpan t = d3.Subtract(d1); // Subtração de datas

            Console.WriteLine(t);

        }
    }
}
