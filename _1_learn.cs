string MyLove = "Ananya";
string MyFriend = "      Manish       ";
string My2Friend = "      Priyanshu       ";
string ManishRealName = MyFriend.Trim();

Console.WriteLine("Hello ,"+ MyFriend);
// We can also use this 
Console.WriteLine($"Hello , {MyLove} ");

// find the length of a string 
Console.WriteLine($"{MyLove} has {MyLove.Length} letters.");
Console.WriteLine($"{MyFriend} has {MyFriend.Length} letters. Which is wrong answer");

// Remove whitespace from strings
Console.WriteLine($"remove spaces from the start of {MyFriend.TrimStart()} .");
Console.WriteLine($"remove spaces from the end of {MyFriend.TrimEnd()} .");
Console.WriteLine($"{ManishRealName} has {ManishRealName.Length} letters.");

// The Replace method takes two parameters.
My2Friend = My2Friend.Replace("Priyanshu","Akash");
Console.WriteLine($"My new friend  is {My2Friend}");

//we can use 2 or more methods on a given variable by using . betwwen them
Console.WriteLine($"So now I have 2 friends {My2Friend.ToUpper().Trim()} & {MyFriend.ToLower().Trim()}.");

//You can use the Contains method for searching. It tells you if a string contains a substring inside it.
string songLyrics = "Office de targte shad , bandiyon ki date shad , iphone update shad , shad veere shad";
Console.WriteLine(songLyrics.Contains("Office de targte shad"));
Console.WriteLine(songLyrics.StartsWith("Office"));
Console.WriteLine(songLyrics.EndsWith("shad"));

