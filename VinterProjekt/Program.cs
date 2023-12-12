// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string[] names = {"Pickachu", "Mewtwo","Charizard","Bulbausar"};
string[] names2 ={"Squirtle","Charmander","Greninja","abdi"};
string[] names3 ={"shuno","Snubbe","skiti","okej"};
//Tre arrays med namn med olika pokemons

string[] FighterNames = {"Incineroar","Dragonite","Lapras"};
// Olika fighters/pokemons som man kan möta
int FighterR = generator.Next(3);
//Tar random vilken fighter man möter

int Card1 = generator.Next(4);
int Card2 = generator.Next(4);
int Card3 = generator.Next(4);
//Tar en pokemon random från varje array

string[] commentsFirst = {"Intresting choice but it might work.", "A personal favorite actually.", "Not what i would have choosen.", "Good enough, Probably", "Thats a strong fighter!"};
//Olika kommentarer som kan komma när man valt pokemon

string[] attacks = {};
//Lista med olika attacker som man kan välja emellan

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
Thread.Sleep(500);
choosePokemon+=1;
}

else if (Pokemon == "2"){
Thread.Sleep(500);
choosePokemon+=2;    
}

else if (Pokemon == "3"){
Thread.Sleep(500);
choosePokemon+=3;    
}

else {
Console.WriteLine("Choose pokemon 1, 2 or 3");  
Pokemon = Console.ReadLine();
}
}

Console.WriteLine("Choose difficulty \n1.Easy \n2.Normal \n3.Hard");
string difficulty = Console.ReadLine();

int chooseDifficulty = 0;
while (chooseDifficulty == 0){
if (difficulty == "1"){
Thread.Sleep(500);
chooseDifficulty+=1;
}

else if (difficulty == "2"){
Thread.Sleep(500);
chooseDifficulty+=2;    
}

else if (difficulty == "3"){
Thread.Sleep(500);
chooseDifficulty+=3;    
}
else {
Console.WriteLine("Choose difficulty 1, 2 or 3");  
difficulty = Console.ReadLine();
}
}


int commentsFirstR = generator.Next(5);
//väljer random vilken kommentar som ska sägas från listan "commentsFirst"



int Health = 25; //Spelarens Health
int HealthOpp = 0; //Fiendes Health
if(chooseDifficulty == 1){
HealthOpp = 20; 
}
if(chooseDifficulty == 2){
HealthOpp = 25; 
}
if(chooseDifficulty == 3){
HealthOpp = 35; 
}

while (Health > 0 || HealthOpp > 0) {
if (Health < 0) {
Health = 0;
}
if (HealthOpp < 0) {
HealthOpp = 0;
}
if (choosePokemon == 1) {
Console.WriteLine($"You have chosen {names[Card1]}! \n {commentsFirst[commentsFirstR]}");
Thread.Sleep(2500);

Console.WriteLine($"Your Opponent is {FighterNames[FighterR]}");
Thread.Sleep(2500);

Console.WriteLine($"{names[Card1]} Gets to start!\nChoose a attack 1.Volt Tackle or 2.");

break;
}

if (choosePokemon == 2) {
Console.WriteLine($"You have chosen {names2[Card2]}! \n {commentsFirst[commentsFirstR]}");
Thread.Sleep(2500);

break;
}

if (choosePokemon == 3) {
Console.WriteLine($"You have chosen {names3[Card3]}! \n {commentsFirst[commentsFirstR]}");
Thread.Sleep(2500);


break;
}



}


