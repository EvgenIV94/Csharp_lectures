// Первая лекция по языку C#
// прежде чем начать работу с текстовым файлом, необходимо ввести в терминале 'dotnet new console', а перед этим выбрать репозиторий с этим файлом
// Для вывода объекта в терминал, используем Console.WriteLine()
//Console.WriteLine("Hello, world!");

// int value = 100;        // Задаем тип, имя и значение переменной
// Console.WriteLine(value);

// Виды переменных
// int = -2*10**31 ... 2*10**31
// long = -2*10**63 ... 2*10**63
// float = ±1.5*10**-45 ... ±3.4*10**38
// double = ±5*10**-324 ... ±1.7*10**308
// char = 0 ... 65535    символы
// bool = true or false

// double d = 5.55;
// char c = '!';
// bool b = true;

// Console.WriteLine(d);
// Console.WriteLine(c);
// Console.WriteLine(b);

// int a = 5;
// int b = 6;
// int sum = a + b;        // необходимо каждой переменной присваивать тип данных
// Console.WriteLine(sum); 

// long a = 6;
// int b = 7;
// long sum = a + b;   // если мы складываем разные типы данных, то тип суммы будет более расширенный тип данных. Например int + long = long
// Console.WriteLine(sum);


// double a = 5.5;
// int b = 2;
// double sum = a + b;     // сумма будет типа double
// Console.WriteLine(sum);

// int a = 5;
// int b = 6;
// int quotient = a / b;       // ответ должен быть 5/6, но вывод = 0. У int нет дробной части
// Console.WriteLine(quotient);

// int a = 5;
// double b = 6;
// double quotient = a / b;       // ответ 0.8(3)
// Console.WriteLine(quotient);

// int a = 5;
// int b = 15;
// double c = 7;
// int d = 2;

// double i = (a*b)/(c+d);
// Console.WriteLine(i);

// int a = 9;
// int b = 7;

// if (a > b)
// {
//     Console.WriteLine(a);
// }
// else
// {
//     Console.WriteLine(b);
// }
// Запись условия if - else


// int a = 20;
// int b = 25;
// int c = 30;
// int d = 35;
// int e = 3;

// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// if (d > max)
// {
//     max = d;
// }
// if (e > max)
// {
//     max = e;
// }
// Console.WriteLine(max);      // в C# нету операции elif


int n = 10;
int i = 1;

while (i <= n)       // пока i <= n
{
    // Console.WriteLine(i);
    Console.Write(i);       // вывод в строку
    Console.Write(' ');     // разделяем пробелом
    i = i + 1;
}
