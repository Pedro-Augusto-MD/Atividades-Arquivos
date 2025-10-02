using System;
using System.Text;

public class exercicio2
{
    public static void Main(string[] args)
    {
        

        FileStream meuArquivo2 = new FileStream("arq_ex2.txt", FileMode.Open, FileAccess.Write);
        StreamWriter escritor2 = new StreamWriter(meuArquivo2, Encoding.UTF8);

        string str = string.Empty;

            Console.WriteLine("Digite um numero interio: ");
            bool valor1 = int.TryParse(Console.ReadLine(), out int numero1);

            Console.WriteLine("Digite outro numero interio: ");
            bool valor2 = int.TryParse(Console.ReadLine(), out int numero2);

            int soma = numero1 + numero2;

            escritor2.WriteLine("A soma dos dois números é: " + soma);

        escritor2.Close();
        meuArquivo2.Close();
    }
}