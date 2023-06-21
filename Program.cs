void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (fun == 03)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (fun == 04)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
}

void SemCor()
{

Console.ResetColor();

}

string username, answer;
int numericName;
bool validUsername, validNumber;

double a = 0, b = 0, c = 0;
Console.Clear();
Shin("\nBEM VINDO(A)! ESTE PROGRAMA CALCULARÁ BHASKARA PARA VOCÊ!",02);
SemCor();
Shin("\nMas antes por favor me diga seu nome..: ",02);
SemCor();
username = Console.ReadLine()!;
validUsername= Int32.TryParse(username, out numericName);

if (validUsername)
{
Console.Clear();
Shin("O VALOR DIGITADO NÃO CORRESPONDE A UM VALOR LITERAL!",03);
SemCor();
Environment.Exit(-1);

}

Console.Clear();

Shin($"Agora vamos lá {username.ToUpper()}!",04);
Shin("\n\nDigite o valor de (A)..:",05);
answer = Console.ReadLine()!;
validNumber = double.TryParse(answer, out a);
if (validNumber == true)
{
    a = double.Parse(answer);
}
else if (validNumber == false)
{
    a = 0;
}
if(a == 0)

{

Console.Clear();
Shin("O VALOR FORNECIDO NÃO É UMA EQUAÇÃO DE SEGUNDO GRAU!",03);
SemCor();
Environment.Exit(-1);
}

Console.Write("Digite o valor de (B)..:");
answer = Console.ReadLine()!;
validNumber = double.TryParse(answer, out b);
if (validNumber == true)
{
    b = double.Parse(answer);
}
else if (validNumber == false)
{
    b = 0;
}


Console.Write("Digite o valor de (C)..:");
answer = Console.ReadLine()!;
validNumber = double.TryParse(answer, out c);
if (validNumber == true)
{
    c = double.Parse(answer);
}
else if (validNumber == false)
{
    c = 0;
}
double delta = (b * b) - 4 * (a * c);
double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

if(delta < 0)

{
Console.Clear();
Shin($"COMO DELTA = {delta:n2}, A EQUAÇÃO NÃO POSSUÍ RAÍZES REAIS!",03);
SemCor();
Environment.Exit(-1);
}

Console.WriteLine("\n\n-- Equação do segundo grau --");
Console.WriteLine($"\n\nResultado (x1)..:{x1:N2}");
Console.WriteLine($"\nResultado (x2)..:{x2:N2}");

Shin($"\nESPERO QUE TENHA TE AJUDO {username.ToUpper()}!",02);
SemCor();