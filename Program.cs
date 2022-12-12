int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;	
} while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");


/*
int numero = 5;
int contador = 0;

while(contador <= 10)
{
    Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if(contador == 5)
{
    break;
}

}



int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/

