// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string[] names = {"Pickachu", "Mewtwo","Charizard","Bulbausar"};
string[] names2 ={""};
string[] names3 ={""};
//Tre listor med namn med olika pokemons

int Card1 = generator.Next(4);
int Card2 = generator.Next(4);
int Card3 = generator.Next(4);
//Tar en pokemon random från varje lista

Console.WriteLine("Welcome to Pokemon Card Battle\nChoose a Fighter!");
Console.WriteLine(names[Card1]);
Console.WriteLine(names2[Card2]);
Console.WriteLine(names3[Card3]);
Console.ReadLine();
    
