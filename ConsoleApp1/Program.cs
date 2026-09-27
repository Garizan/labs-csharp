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
