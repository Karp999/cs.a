/* Задача: высчитать свой возраст по дате рождения
int GetAge(DateTime birthDate)
{
    var now = DateTime.Today;
    return now.Year - birthDate.Year - 1 +
        ((now.Month > birthDate.Month || now.Month == birthDate.Month && now.Day >= birthDate.Day) ? 1 : 0);
}

var birthDate = 09.09.96,
GetAge(birthDate);
*/