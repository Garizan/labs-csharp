/*
 *lab2 
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(2000);
A();
A();
A();


void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void A()
{
    Console.WriteLine("A");
    B();
    C();
}
void B()
{
    Console.WriteLine("B");
}
void C()
{
    Console.WriteLine("C");
}
*/
// lab4
int a = 5;
int b = 6;
a = b;
b = 7;
Console.WriteLine(a);

int x = 5;
int y = x + 6;
x = 7;
Console.WriteLine(y);

string c = "1";
string d = c;
c = "2";
Console.WriteLine(c);
Console.WriteLine(d);