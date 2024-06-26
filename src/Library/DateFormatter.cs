﻿using System.Text;

namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    // OPCIÓN 1:
    //     StringBuilder newDate = new StringBuilder();
    //     bool isValid = true;

    //     if (String.IsNullOrEmpty(date))
    //     {
    //         newDate.Append("La fecha no puede ser vacía");
    //         isValid = false;
    //     }

    //     else if (date.Length != 10)
    //     {
    //         newDate.Append("La longitud de la fecha tiene que tener 10 caracteres");
    //         isValid = false;
    //     }

    //     if (isValid)
    //     {
    //         newDate.Append(date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2));
    //     }

    //     return newDate.ToString();

    // }
    // OPCIÓN 2:
    {
        // En caso de que la fecha de entrada sea vacía, que me avise
        if (String.IsNullOrEmpty(date))
        {
            return "La fecha no puede ser vacía";
        }

        // En caso que la longitud de la fecha de entrada sea diferente de 10, que me avise
        if (date.Length != 10)
        {
            return "La longitud de la fecha tiene que tener 10 caracteres";
        }

        // En caso que la fecha cumpla con las restricciones de longitud, que me cambie el formato
        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
}
