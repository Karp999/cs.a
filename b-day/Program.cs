Console.Clear();

DateTime myDateOfBirth = new DateTime(1996, 9, 9); 
Console.WriteLine($"Date of birthday: {myDateOfBirth.ToShortDateString()}");
DateTime todayBday = new DateTime(2022, 9, 9); 
Console.WriteLine($"Today: {todayBday.ToShortDateString()}");
Console.WriteLine($"Hello,{(todayBday.Subtract(myDateOfBirth))/360} Anya's years!♥ ♥ ♥ ");

/*
int CalculateAge(DateTime birthDate)
{todayBday.Subtract(myDateOfBirth)
    DateTime birthDate = new DateTime(1996, 9, 9);
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;
    if (birthDate.AddYears(age) > today)
    {
        age--;
    }
    return age;
}
*/