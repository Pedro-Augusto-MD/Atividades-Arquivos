using System;
using System.Text;

public class exercicio1
{
    public static void Main(string[] args)
    {
        FileStream meuArquivo1 = new FileStream("arq_ex1.txt", FileMode.Open, FileAccess.Read);
        StreamReader leitor1 = new StreamReader(meuArquivo1, Encoding.UTF8);
        while (!leitor1.EndOfStream)
        {
            float numero2 = 0, numero1 = 0;
            string? linha1 = leitor1.ReadLine();
            bool valor1 = linha1 != null && float.TryParse(linha1, out numero1);

            string? linha2 = leitor1.ReadLine();
            bool valor2 = linha2 != null && float.TryParse(linha2, out numero2);

            float soma = 0;
            if (valor1 && valor2)
            {
                soma = numero1 + numero2;
            }
            Console.WriteLine("A soma dos dois números é: " + soma);
        }

        

        leitor1.Close();
        meuArquivo1.Close();
    }
}