var balans = 1000;

var random = new Random(3);

while (true)
{
    var slotunXanalari = "";
    Console.WriteLine("\nBalans: " + balans);
    Console.WriteLine("\nOyuna baslamaq ucun entere basin!");
    Console.ReadLine();

    balans -= 5;


    for (int i = 0; i < 3; i++)
    {
        var r = random.Next(1,3);

        if (r == 1)
        {
            slotunXanalari += "@";
        }
        else if (r == 2)
        {
            slotunXanalari += "$";
        }
        else
        {
            slotunXanalari += "#";
        }
    }

    Console.WriteLine(slotunXanalari);


    if (slotunXanalari == "@@@" || slotunXanalari == "$$$" || slotunXanalari == "###")
    {
        balans += 50;
        Console.WriteLine("Tebrikler uddunuz!");
    }

    Console.WriteLine("");


}







