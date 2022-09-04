using Microsoft.VisualBasic.FileIO;
using Restraunt_Picker;
using System.ComponentModel;


/*
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

*/

//--------------------------------------------------------------------------------------------------------------------------------
/*
Restraunts bk = new Restraunts
{
    ID=1,
    name="Burger King",
    priceRange="Cheap",
    cusine="American",
    sitIn=true,
    driveThru=true
};

*/

//count the index, take that number and remove one and you have the last entered id index


List<Restraunts> Restlist = new List<Restraunts>();
int newId = Restlist.Count();
bool GoingAgain = false;
var DriveThruBool =false;
var SitInBool =false;
void NewRest()
{
//Variable
Console.WriteLine("New Variable Required to add Restraunt");
string rest = Console.ReadLine();


//Name of Restraunt
Console.WriteLine("What is the Name of your Restraunt?");
string name = Console.ReadLine();


//Price Range of the Restraunt (cheap, average, and expensive)
Console.WriteLine("What is the Price Range of your Restraunt?");
string price = Console.ReadLine();


//Cusine type. Can not be null
Console.WriteLine("What is the Cusine Type of your Restraunt?");
string cusineT = Console.ReadLine();


//SitIn (True or False)
Console.WriteLine("Is there a dine in option at your Restraunt?");
string SitIn = Console.ReadLine();
    if (SitIn == "yes" || SitIn == "y" || SitIn == "Yes")
    {
        SitInBool = true;
    }
    

//DriveThru Avaible (True or False)
Console.WriteLine("Is there a Drive Thru at your Restraunt?");
string DriveThru = Console.ReadLine();
    if (DriveThru == "yes" || DriveThru == "y" || DriveThru == "Yes")
    {
        DriveThruBool = true;
    }


    //Prefrence, does someone not want to go to a place. Default value is true, can be toggled in search
    //Console.WriteLine("What is the Name of your Restraunt?");
    //string Prefrence = Console.ReadLine();


    Restraunts newrest = new Restraunts             //Having a problem where it's making a new list everytime you run this method
    {
    ID =newId,
    name = name,
    priceRange = price,
    cusine = cusineT,
    sitIn = SitInBool,
    driveThru = DriveThruBool,
    IndxValue = newId
};
        Restlist.Add(newrest);
        Console.WriteLine(Restlist[newId]);

    Console.WriteLine("Would you like to add another Restraunt?");
    string GoAgain = Console.ReadLine();
    if (GoAgain == "yes" || GoAgain == "y" || GoAgain == "Yes")
    {
        GoingAgain = true;
    newId = ++newrest.ID;
        NewRest();
    }

}

//NewRest();


void DeleteRest()
{
    int indxSpot = Restlist.Count() - 1;            //Retrieves the index location from the restraunt list

    foreach(Restraunts rest in Restlist)
    {
        Console.WriteLine($"{rest.ID}, {rest.name}");
    }
    Console.WriteLine("Please enter the number of the restraunt you'd like to remove. Enter anything other than a number to cancel");
    string userAnswer = Console.ReadLine();
    
    if(Convert.ToInt32(userAnswer) == indxSpot)
    {
        Restlist.RemoveAt(indxSpot);
        Console.WriteLine($"The Restraunt at Index Spot {indxSpot} was removed ");
    }
    
    else Console.WriteLine("Restraunt Removal Canceled ");

    Console.WriteLine("Would you liket to re-run?");
    string reRun = Console.ReadLine();

    if (reRun == "yes" || reRun == "y" || reRun == "Yes")
    {
        DeleteRest();
    }
    else Console.WriteLine("Have a Good Day!");
}

DeleteRest();
