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



var keyValuePairs1 = new Dictionary<string, Dictionary<string, fine>>();

keyValuePairs1.Add("10AZ100", new Dictionary<string, fine> {
    {
        "Hesen Eliyev kucesi" ,

        new fine()

        {
            street= "Hesen Eliyev kucesi " ,

           money = 100

             }

        }

});











string input = Console.ReadLine();


Console.WriteLine(keyValuePairs["10AZ100"]["Ismayil"].Name + "   " + (keyValuePairs["10AZ100"]["Ismayil"].Age + "  " + keyValuePairs1["10AZ100"]["Hesen Eliyev kucesi"].street+ keyValuePairs1["10AZ100"]["Hesen Eliyev kucesi"].money));



var keyValuePairs2 = new Dictionary<string, Dictionary<string, Person>>();

keyValuePairs.Add("10NB755", new Dictionary<string, Person>
{
    {
        "Elsen" ,

        new Person()

        {
            Name= "Elsen" ,

            Age = 18 }

        }

});


var keyValuePairs3 = new Dictionary<string, Dictionary<string, fine>>();

keyValuePairs1.Add("10NB755", new Dictionary<string, fine> {
    {
        "9cu Mkr dairesi" ,

        new fine()

        {
            street= "9cu Mkr dairesi " ,

           money = 75

             }

        }

});

string input1 = Console.ReadLine();

Console.WriteLine(keyValuePairs["10NB755"]["Elsen"].Name + "   " + (keyValuePairs["10NB755"]["Elsen"].Age + "  " + keyValuePairs1["10NB755"]["9cu Mkr dairesi"].street + keyValuePairs1["10NB755"]["9cu Mkr dairesi"].money));

