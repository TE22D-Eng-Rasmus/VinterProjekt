// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string[] names = {"Pickachu", "Mewtwo","Charizard","Bulbausar"};
string[] names2 ={"Squirtle","Charmander","Greninja","4"};
string[] names3 ={"1","2","3","4"};
//Tre arrays med namn med olika pokemons

string[] FighterNames = {"Incineroar"};
// Olika fighters/pokemons som man kan möta

int Card1 = generator.Next(4);
int Card2 = generator.Next(4);
int Card3 = generator.Next(4);
//Tar en pokemon random från varje array

Console.WriteLine("Welcome to Pokemon Card Battle\nChoose a Fighter!");
Console.Write("1 ");
Console.Write(names[Card1]);
Console.WriteLine("");
Console.Write("2 ");
Console.Write(names2[Card2]);
Console.WriteLine("");
Console.Write("3 ");
Console.Write(names3[Card3]);
Console.WriteLine("\nChoose pokemon 1, 2 or 3");
String Pokemon = Console.ReadLine();

//gör så att du måste välja en pokemon
int choosePokemon = 0;
while (choosePokemon == 0){
if (Pokemon == "1"){
Console.WriteLine("1");
Console.ReadLine();
choosePokemon+=1;
}
else if (Pokemon == "2"){
Console.WriteLine("2");
Console.ReadLine();
choosePokemon+=2;    
}
else if (Pokemon == "3"){
Console.WriteLine("3");
Console.ReadLine();
choosePokemon+=3;    
}
else {
Console.WriteLine("Choose pokemon 1, 2 or 3");  
Pokemon = Console.ReadLine();
}
}


if (choosePokemon == 1) {
Console.WriteLine(names[Card1]);
Console.ReadLine();
}

if (choosePokemon == 2) {
Console.WriteLine(names[Card2]);
Console.ReadLine();
}

if (choosePokemon == 3) {
Console.WriteLine(names[Card3]);
Console.ReadLine();
}


