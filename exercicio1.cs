namespace estrutura_decisao_cs;

//1.	Faça um Programa que peça dois números e imprima o maior deles.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## QUAL É O MAIOR NUMERO? ##");
        Console.WriteLine("");

        Console.WriteLine("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("O primeiro número é maior. ");
        }
        else if (numero2 > numero1)
        {
           Console.WriteLine("O segundo número é maior. "); 
        }
        else {
            Console.WriteLine("Os números são iguais");
        }

    }
}
