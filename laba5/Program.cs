
//int a = 5;
//F();

//static void F()
//{
//    int b = 6;
//}

// int a = 5;
// F();
//
// static void F()
// {
//     int a = 6;
// }

// int a = 5;
// F(a);
//
// static void F(int b)
// {
//     b = 6;
// }


// int b = 6;
// F(1, b);
//
// static int F(int a, int b)
// {
//     return a + b;
// }

// int b = 6;
// int s = F(1, b);
// b = s;
//
// static int F(int a, int b)
// {
//     return a + b;
// }


/*
 * Сработает F(2, b) которая вернёт 8, затем 2 функция и вернёт 9 и в конце сработает последняя функция - 15. 
 */
// int b = 6;
// int s = F(F(1, F(2, b)), b);
//
// static int F(int a, int b)
// {
//     return a + b;
// }

/*
 * Бесконечное количество вызовов пока не вылетит ошибка StackOverflowException.
 */
// F(1);
//
// static void F(int a)
// {
//     F(a);
// }

// int a = 1;
// F(a + 2);
// a = 10;
//
// static void F(int x)
// {
//     Console.WriteLine(x);
// }

// int a = 1;
// int b = F(a);
// a = 2;
//
// Console.WriteLine(a);
// Console.WriteLine(b);
//
// static int F(int x)
// {
//     return x;
// }

string s = GetGreeting();
Console.WriteLine(s);

static string GetGreeting()
{
    return "Привет";
}