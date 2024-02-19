/*
Scrieti un program care va afisa suma cifrelor unui numar
* intreg citit de la tastatura
*/

Console.WriteLine("Introduceti un numar intreg cu 2 cifre:");
int numar = int.Parse(Console.ReadLine());

int cifraUnu, cifraDoi, sum=0;

if
    (numar < 100)
{
    if (numar > 9)
    {
        cifraDoi = numar % 10;
        cifraUnu = numar / 10;
        sum = cifraUnu + cifraDoi;
        Console.WriteLine("Suma cifrelor este:" + sum);
    }
    else 
    {
        Console.WriteLine("Numarul are doar 1 cifra");
    }

}
else
{
    Console.WriteLine("Numarul nu are 2 cifre");
}