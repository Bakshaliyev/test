using System.Net.WebSockets;

Console.WriteLine("Kartin nomresini daxil edin");
int cardnumber = Convert.ToInt32(Console.ReadLine());

switch (cardnumber)
{

        case 0:
        Console.WriteLine(5);
        break;

        case 1:
        Console.WriteLine("Deyeri: "+   10);
        break;

        case 2:
        Console.WriteLine("Deyeri: "+ 15);
        break;

        case 3: 
        Console.WriteLine("Deyeri: " + 20); 
        break;

        case 4:
        Console.WriteLine("Deyeri: " + 25);
        break;

        case 5:
        Console.WriteLine("Deyeri: " + 30);
        break;

        case 6:
        Console.WriteLine("Deyeri: " + 35);
        break;

        case 7:
        Console.WriteLine("Deyeri: " + 40);
        break;

        case 8:
        Console.WriteLine("Deyeri: " + 45);
        break;

        case 9:
        Console.WriteLine("Deyeri: " + 50);
        break;

        case 10:
        Console.WriteLine("Deyeri: " + 55);
        break;

        default :
        Console.WriteLine("Kart nomresi 10 qederdir ");
        break;
       


}
