string Fname = "Ritesh";
String Lname = "Ritesh";

Console.WriteLine(Fname.Length);
Console.WriteLine(Lname.Length);

//join two String:-
string joinedString = string.Concat(Fname," ", Lname);
Console.WriteLine(joinedString);

//add another string "Rajkot" to previous Strings
joinedString = string.Concat(joinedString, "Rajkot");
Console.WriteLine(joinedString);

//compare str1(Fname) and str2(Lname)
Boolean result1 = Fname.Equals(Lname);
Console.WriteLine("Comapre OF Lname and Fname: "+result1);

//UPPER 
Console.WriteLine(Fname.ToUpper());
Console.WriteLine(Lname.ToUpper());

//LOWER
Console.WriteLine(Fname.ToLower());
Console.WriteLine(Lname.ToLower());


bool check = Fname.Contains("sh");
Console.WriteLine(check);

string result2 = Lname.Substring(2);
string result3 = Lname.Substring(1,3);
Console.WriteLine(result2);
Console.WriteLine(result3);

int compare = String.Compare(Fname, Lname);
Console.WriteLine(compare);

string insertName = Fname.Insert(2, "Hello");
Console.WriteLine(insertName);

int lastIndex = Fname.LastIndexOf("h");
Console.WriteLine(lastIndex);

string remove = Lname.Remove(4);
Console.WriteLine(remove);

string replace = Lname.Replace('L', 'l');
Console.WriteLine(replace);

//clone()
Console.WriteLine("Clone : "+Fname.Clone());

//ComapareTo
Console.WriteLine("Compare To : "+Fname.CompareTo(Lname));

//EndsWith()
Console.WriteLine("Ends With: "+Fname.EndsWith("n"));

//Start With()
Console.WriteLine("Start With: " + Lname.StartsWith("L"));

//Trim()
Console.WriteLine("Trim: " + Fname.Trim());

