// See https://aka.ms/new-console-template for more information
Console.WriteLine("kő=0 papír=1 olló=2");
Console.Write("első játékos:");
string jatekos1 = Console.ReadLine();

Console.Write("második játékos:");
string jatekos2 = Console.ReadLine();
int ko = 0;
int papir = 1;
int ollo = 2;

if (jatekos1 ==0)
{
    Console.WriteLine("jatekos : k");
}
else if (jatekos1 == 1)
{
    Console.WriteLine("jatekos : p");
}
else if  (jatekos1 == 2)
{
    Console.WriteLine("jatekos : o");
}


if (jatekos2 == 0)
{
    Console.WriteLine("jatekos : k");
}
else if (jatekos2 == 1)
{
    Console.WriteLine("jatekos : p");
}
else if (jatekos2 == 2)
{
    Console.WriteLine("jatekos : o");
}






if (jatekos1 == 0 & jatekos2 == 0 || jatekos1 == 1 & jatekos2 == 1 || jatekos1 == 2 & jatekos2 == 2)
{

    Console.WriteLine("Döntetlen.");
}
if (jatekos1 == 0 & jatekos2 == 1 || jatekos1 == 1 & jatekos2 == 2 || jatekos1 == 2 & jatekos2 == 0)
{

    Console.WriteLine("2. játékos nyert");
}
if (jatekos2 == 0 & jatekos1 == 1 || jatekos2 == 1 & jatekos1 == 2 || jatekos2 == 2 & jatekos1 == 0)
{

    Console.WriteLine("1. játékos nyert");
}
Console.ReadLine();