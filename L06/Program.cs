Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("O");

int xa = 30, ya = 1,
    xb = 1, yb = 10,
    xc = 60, yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("O");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("O");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("O");

int x = xa, y = xb;

int count = 10;

while(count < 100);
{
    int what = new Random().Next(0, 3); // (0,3) 0 1 2
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
 
    if(what == 0)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if(what == 0)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("0");
    count++;
}