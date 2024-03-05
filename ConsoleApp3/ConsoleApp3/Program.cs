using ConsoleApp3;

var keyValuePairs = new Dictionary<string, Dictionary<string, Person>>();

keyValuePairs.Add("10AZ100", new Dictionary<string, Person>
{
    {
        "Ismayil" ,

        new Person()

        {
            Name= "Ismayil" ,

            Age = 18 }

        }

});



var keyValuePairs1 = new Dictionary<string, Dictionary<string, Person1>>();

keyValuePairs1.Add("10AZ100", new Dictionary<string, Person1> {
    {
        "Hesen Eliyev kucesi" ,

        new Person1()

        {
            street= "Hesen Eliyev kucesi " ,

             }

        }

});

//Console.WriteLine(keyValuePairs["10AZ100"]["Ismayil"].Name + "   " + (keyValuePairs["10AZ100"]["Ismayil"].Age + "  " + keyValuePairs1["10AZ100"]["Hesen Eliyev kucesi"].street));

string input = Console.ReadLine();


Console.WriteLine(keyValuePairs["10AZ100"]["Ismayil"].Name + "   " + (keyValuePairs["10AZ100"]["Ismayil"].Age + "  " + keyValuePairs1["10AZ100"]["Hesen Eliyev kucesi"].street));

