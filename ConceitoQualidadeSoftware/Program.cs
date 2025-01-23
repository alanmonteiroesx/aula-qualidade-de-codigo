namespace ConceitoQualidadeCodigo
{
    internal static class Program
    {
        private const string MENSAGEM_SEXTOU = " #sextou";
        static void Main(string[] args)
        {
            V7();
        }

        private static void V1()
        {
            var a = DateTime.Now.Year;
            var m = DateTime.Now.Month;
            var janeiro = new List<DateTime>();
            for (int i = 1; i <= DateTime.DaysInMonth(a, m); i++)
            {
                if (new DateTime(a, m, i).DayOfWeek == DayOfWeek.Friday)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(new DateTime(a, m, i).ToString("dd/MM/yyyy") + (new DateTime(a, m, i).DayOfWeek
                == DayOfWeek.Friday ? " #sextou" : ""));
            }
        }
        private static void V2()
        {
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;

            for (int dia = 1; dia <= DateTime.DaysInMonth(ano, mes); dia++)
            {
                var data = new DateTime(ano, mes, dia);
                var diaSemana = data.DayOfWeek;

                if (diaSemana == DayOfWeek.Friday)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(data.ToString("dd/MM/yyyy") + (diaSemana == DayOfWeek.Friday ? " #sextou" : ""));
            }
        }
        private static void V3()
        {
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;

            for (int dia = 1; dia <= DateTime.DaysInMonth(ano, mes); dia++)
            {
                var data = new DateTime(ano, mes, dia);
                var diaSemana = data.DayOfWeek;
                var sextou = diaSemana == DayOfWeek.Friday;

                Console.ForegroundColor = sextou ? ConsoleColor.Green : ConsoleColor.White;

                Console.WriteLine(data.ToString("dd/MM/yyyy") + (sextou ? " #sextou" : ""));
            }
        }
        private static void V4()
        {
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;

            for (int dia = 1; dia <= DateTime.DaysInMonth(ano, mes); dia++)
            {
                var data = new DateTime(ano, mes, dia);
                var diaSemana = data.DayOfWeek;
                var sextou = diaSemana == DayOfWeek.Friday;

                Console.ForegroundColor = sextou ? ConsoleColor.Green : ConsoleColor.White;

                Console.WriteLine(data.ToString("dd/MM/yyyy") + (sextou ? " #sextou" : ""));
            }
        }
        private static void V5()
        {
            foreach (var data in ObterDiasMesAtual())
            {
                var mensagem = data.ToStringBr() + (data.EhSexta() ? " #sextou" : "");

                mensagem.ImprimirTextoNaTela(data.EhSexta() ? ConsoleColor.Green : ConsoleColor.White);
            }
        }
        private static void V6()
        {
            foreach (var data in ObterDiasMesAtual())
            {
                var mensagem = data.ToStringBr() + (data.EhSexta() ? MENSAGEM_SEXTOU : string.Empty);

                mensagem.ImprimirTextoNaTela(data.EhSexta() ? ConsoleColor.Green : ConsoleColor.White);
            }
        }
        private static void V7()
            => ObterDiasMesAtual()
                .ForEach(data =>
                    ObterMensagemDiaSemana(data)
                    .ImprimirTextoNaTela(data.EhSexta() ? ConsoleColor.Green : ConsoleColor.White));

        private static string ObterMensagemDiaSemana(DateTime data)
        {
            return data.ToStringBr() + (data.EhSexta() ? MENSAGEM_SEXTOU : string.Empty);
        }
        private static List<DateTime> ObterDiasMesAtual()
        {
            var hoje = DateTime.Now;
            var ano = hoje.Year;
            var mes = hoje.Month;
            var dias = new List<DateTime>();
            for (int dia = 1; dia <= DateTime.DaysInMonth(ano, mes); dia++)
            {
                dias.Add(new DateTime(ano, mes, dia));
            }
            return dias;
        }
        private static void ImprimirTextoNaTela(this string texto, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(texto);
        }
        private static string ToStringBr(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }
        private static bool EhSexta(this DateTime data) => data.DayOfWeek == DayOfWeek.Friday;
    }
}






