// 2.	Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.

using System.ComponentModel;

Console.WriteLine("## POSITIVO E NEGATIVO ##");
Console.WriteLine("");
Console.WriteLine("Digite um numero: ");
 float numero = Convert.ToSingle(Console.ReadLine());

if (numero >= 0){
    Console.WriteLine("O numero é positivo.");
}
else{
    Console.WriteLine("O numero é negativo");
}
