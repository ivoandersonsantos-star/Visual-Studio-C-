int n, i = 0;
int sn = 1;
int p = 0;
int ng = 0;
while (i < 1)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("Quer adicionar mais um número: (Sim = 1  Não =  2 )");
    sn = int.Parse(Console.ReadLine());
    if (sn == 2)
    {
        i++;
        ;
    }
    if (n < 0) {
        ng++;
        ; 
    }
    if (n > 0)
    {
        p++;
        ;
    }
}
Console.WriteLine($"Tem {p} números positivos\nTem {ng} números negativos");
