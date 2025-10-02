using System;
using System.Text;

public class exercicio3
{
    public static void Main(string[] args)
    {
        FileStream meuArquivo4 = new FileStream("arq_ex4.txt", FileMode.Open, FileAccess.Read);
        StreamReader leitor4 = new StreamReader(meuArquivo4, Encoding.UTF8);

        int contVogal = 0;
        int contConsoante = 0;

        while (!leitor4.EndOfStream)
        {
            string linha = leitor4.ReadLine();
            bool valor = char.TryParse(linha, out char caractere);

            string vogais = "aeiouAEIOU";
            string consoantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            if (vogais.Contains(caractere))
            {
                contVogal++;
            }
            if (consoantes.Contains(caractere))
            {
                contConsoante++;
            }
        }

        Console.WriteLine("Número de vogais: " + contVogal);
        Console.WriteLine("Número de consoantes: " + contConsoante);

        leitor4.Close();
        meuArquivo4.Close();
    }
}