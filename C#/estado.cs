using System;

class Estado
{
    public static void Main()
    {
        int hora;

        do
        {
            Console.WriteLine("Reserve seu hor�rio no campo society!");
            Console.WriteLine("Digite quantos dias no m�s:");
            Console.WriteLine("1 - Um dia = R$ 80,00:");
            Console.WriteLine("2 - Dois dias = 10% de desconto:");
            Console.WriteLine("3 - Tr�s dias = 15% de desconto:");
            Console.WriteLine("4 - Quatro dias = 20% de desconto:");
            hora = int.Parse(Console.ReadLine());

            if(hora == 1)
            {
                Console.Clear();
                Console.WriteLine("Voc� marcou 1 dia no valor de R$80,00 sem desconto!");
            }
            if(hora == 2)
            {
                Console.Clear();
                Console.WriteLine("Voc� marcou 2 dias no valor de R$72,00 com 10% de desconto!");
            }
            if(hora == 3)
            {
                Console.Clear();
                Console.WriteLine("Voc� marcou 3 dias no valor de R$68,00 com 15% de desconto!");
            }
            if(hora == 4)
            {
                Console.Clear();
                Console.WriteLine("Voc� marcou 4 dias no valor de R$64,00 com 20% de desconto!");
            }
            if((hora != 1)&&(hora != 2)&&(hora != 3)&&(hora != 4))
            {
                Console.Clear();
                Console.WriteLine("Voc� digitou um n�mero errado!");
            }
        } while ((hora!=1)||(hora!=2)||(hora!=3)||(hora!=4));
        Console.ReadLine();
    }

}