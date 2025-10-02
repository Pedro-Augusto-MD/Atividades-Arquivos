using System;
using System.Text;

public class exercicio3
{
    public static void Main(string[] args)
    {
        FileStream meuArquivo3 = new FileStream("arq_ex3.txt", FileMode.Open, FileAccess.Read);
        StreamReader leitor3 = new StreamReader(meuArquivo3, Encoding.UTF8);

        while (!leitor3.EndOfStream)
        {
            string linha = leitor3.ReadLine();
            bool valor = float.TryParse(linha, out float numero);

            float raizQuadrada = (float)Math.Sqrt(numero);
            Console.WriteLine(raizQuadrada);
        }

        leitor3.Close();
        meuArquivo3.Close();
    }
}