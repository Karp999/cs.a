Console.Clear();

DateTime myDateOfBirth = new DateTime(1996, 9, 9); 
Console.WriteLine($"Date of my birthday: {myDateOfBirth.ToShortDateString()}");
DateTime todayBday = new DateTime(2022, 9, 9); 
Console.WriteLine($"Today: {todayBday.ToShortDateString()}");
TimeSpan Age = (todayBday.Subtract(myDateOfBirth))/360;
string text = ($"♥ Hello, my {Age} ");
text = text.Substring(0, text.Length-10); 
Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();





