
String[] Restraunts = { "Mcdonald's", "Chiptole", "Chic Fil A", "Burger King", "Ihop", "Noodles and Co", "Cloud 9", "Taco Bell", "Skyline/Gold Star", "Qdoba"};

string response = "Waiting";
 
Random rd = new Random();

int rand_num = rd.Next(0,10);

Console.WriteLine(Restraunts[rand_num]);
Console.WriteLine("Is this the restraunt you'd like to eat at? y or n");
response = Console.ReadLine();

if (response == "y")
{
    Console.WriteLine("Enjoy your meal!");

}

while (response == "n")
{
    rand_num = rd.Next(0, 10);
    Console.WriteLine(Restraunts[rand_num]);
    Console.WriteLine("Is this the restraunt you'd like to eat at? Y or N");
    response = Console.ReadLine();
}

if (response == "y")
{
    Console.WriteLine(" Enjoy your meal!");

}
