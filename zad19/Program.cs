Console.WriteLine("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());
string k = Convert.ToString(n);


if (k[0] == k[4] && k[1] == k[3])
        Console.WriteLine("Да, это палиндром");

else
        Console.WriteLine("Нет");
