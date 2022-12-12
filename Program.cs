string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opcao:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    
    opcao = Console.ReadLine();
    
    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
    case "2":
            Console.WriteLine("Bu de cliente");
            break;
    case "3":
            Console.WriteLine("Apagar cliente");
            break;
    case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
    default:
            Console.WriteLine("Opcao errada");
            break;
    }
}

Console.WriteLine("O programa se encerrou");



/*
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;	
} while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");



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

