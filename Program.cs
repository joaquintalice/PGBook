// Console is a class which have a (dot "." operator or member access operator) and WriteLine is the method. 

Console.WriteLine("What kind of thing are we talking about?");
string kindOfThing = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string descriptionOfThing = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + kindOfThing + " " + descriptionOfThing + /*" of "*/ " " + c + " " + d + "!");