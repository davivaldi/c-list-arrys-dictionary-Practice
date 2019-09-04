using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sarah"};
            bool[] arr = {true,false,true,false,true,false,true,false,true,false};

// ***************************************List*************************************

List<string> flavors = new List<string>();

flavors.Add("Strawberry");
flavors.Add("Chocolate");
flavors.Add("Rocky Road");
flavors.Add("Maple Nut");
flavors.Add("Cherry");

for (var idx = 0; idx < flavors.Count; idx++)
{
 Console.WriteLine("-" + flavors[idx]);
}

Console.WriteLine($"We currently have {flavors.Count} in the Parlor");

Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);

Console.WriteLine($"We currently have {flavors.Count} in the Parlor");



// ********************************Dictionary***********************************


Dictionary<string,string> user= new Dictionary<string,string>();

user.Add("Name", "Diamond Davi Savage");
user.Add("Language", "C#");

Console.WriteLine("Gamer Profile");
Console.WriteLine("Name - " + user["Name"]);
Console.WriteLine("Favorite Language - " + user["Language"]);


foreach (KeyValuePair<string,string> entry in user){
    Console.WriteLine(entry.Key + "-"+ entry.Value);
}


// ***************************boxing/unboxing****************

List<object> boxing = new List<object>();
boxing.Add(7);
boxing.Add(28);
boxing.Add(-1);
boxing.Add(true);
boxing.Add("chair");

for (var idx = 0; idx < boxing.Count; idx++)
{
 Console.WriteLine("-" + boxing[idx]);
}



// object boxedData= boxing;
// int value = 0;
// if (boxedData is int){
//  value+=boxedData;
// }



// ***************************functionsAssignment*******************************















        }
    }
}
