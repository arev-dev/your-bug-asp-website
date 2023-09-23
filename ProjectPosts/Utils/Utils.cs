using System;

namespace ProjectPosts.BLL.Utils
{
    public class DateUtils 
    {
        public static string FormatDateTimeNow(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            TimeSpan diferencia = fechaActual - fecha;
            int segundos = (int)diferencia.TotalSeconds;
            int minutos = segundos / 60;
            int horas = minutos / 60;
            int dias = horas / 24;
            int años = dias / 365;

            if (años > 0)
            {
                return $"hace {años} año{(años > 1 ? "s" : "")}";
            }
            else if (dias > 0)
            {
                return $"hace {dias} día{(dias > 1 ? "s" : "")}";
            }
            else if (horas > 0)
            {
                return $"hace {horas} hora{(horas > 1 ? "s" : "")}";
            }
            else if (minutos > 0)
            {
                return $"hace {minutos} minuto{(minutos > 1 ? "s" : "")}";
            }
            else
            {
                return $"hace {segundos} segundo{(segundos > 1 ? "s" : "")}";
            }
        }
    }
}
