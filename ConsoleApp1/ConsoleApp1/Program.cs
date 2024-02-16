Console.WriteLine("Salam! Getmek istediyiniz olkeni qeyd edin");
Console.ReadLine();

Console.WriteLine("Gedeceyiniz yerin mesafesini qeyd edin");
int distance=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Odeceyiniz mebleg :    " + distance*100 + "  AZN  ");


Console.WriteLine("Endirim kuponundan istifade ederek endirim elde ede bilersiz");
int discount = Convert.ToInt32(Console.ReadLine());

if (discount==1234) 
{
    Console.WriteLine("Endirimli qiymet"+ distance*50);
}

else
{
    Console.WriteLine("Endirim kuponu kecerli deyil");
}

  

