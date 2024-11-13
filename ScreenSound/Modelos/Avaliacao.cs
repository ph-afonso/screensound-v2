using System.Linq.Expressions;

namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        try
        {
            int nota = int.Parse(texto);

            if (nota < 0)
            {
                nota = 0;
            }
            else if (nota > 10)
            {
                nota = 10;
            }

            return new Avaliacao(nota);
        }
        catch (FormatException)
        {
            Console.WriteLine("O valor recebido não pode ser convertido para um inteiro.");
            return new Avaliacao(0);
        }
    }
}
