Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.WriteLine("Введите Фамилию");
string lastname = Console.ReadLine();

Console.WriteLine("Введите день");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите месяц");
int Month = Convert.ToInt32(Console.ReadLine());

if (((Month == 1 && day >= 21) || (Month == 2 && day <= 18)) && day < 29 && day > 0)
{ 
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: водолей"); 
}

if (((Month == 2 && day >= 19) || (Month == 3 && day <= 20)) && day < 29 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: рыба");
};
if (((Month == 3 && day >= 21) || (Month == 4 && day <= 19)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: овен");
};

if (((Month == 4 && day >= 20) || (Month == 5 && day <= 20)) && day < 31 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: телец");
};

if (((Month == 5 && day >= 21) || (Month == 6 && day <= 21)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: близнецы");
};

if (((Month == 6 && day >= 22) || (Month == 7 && day <= 22)) && day < 31 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: рак");
};

if (((Month == 7 && day >= 23) || (Month == 8 && day <= 22)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: лев");
};

if (((Month == 8 && day >= 23) || (Month == 9 && day <= 22)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: дева");
};

if (((Month == 9 && day >= 23) || (Month == 10 && day <= 23)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: весы (ты крутой)");
};

if (((Month == 10 && day >= 24) || (Month == 11 && day <= 22)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: скорпион");
}

if (((Month == 11 && day >= 23) || (Month == 12 && day <= 21)) && day < 31 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: стрелец");
}

if (((Month == 12 && day >= 22) || (Month == 1 && day <= 20)) && day < 32 && day > 00)
{
    Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {lastname}, ваш знак зодиака: козерог");
}
