/*
Как не нужно писать код. Часть 3
*/

void NuturalNumberMN(int numberM, int numberN)
{
    if (numberM < numberN)
    {
        return;
    }
    else
    {
        if (numberM >= numberN)
        {
            System.Console.Write(numberM);
            if (numberN < numberM)
            {
                System.Console.Write(", ");
            }
        }
        NuturalNumberMN(numberM - 1, numberN);

    }
}
NuturalNumberMN(8, 4);