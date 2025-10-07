int n , a = 0;
int b = 0;
Console.WriteLine("Digite um número:");
n = int.Parse(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Número inválido");
    n = -1;
    ;
}
b = n;
while (a<n)
{
    b--;
    Console.WriteLine($"O fatorial é: {n*b}");
    a++;
;}
