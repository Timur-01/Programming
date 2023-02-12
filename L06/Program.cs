Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("O");

int xa = 1, ya = 1,
xb = 1, yb = 30,
xc = 40; yc = 30;

Console.Set.CursorPosition(xa, ya);
Console.WriteLine("0");
Console.Set.CursorPosition(xb, yb);
Console.WriteLine("0");
Console.Set.CursorPosition(xc, yc);
Console.WriteLine("0");
int x = xa, y = xb;

int count = 10;

while(count < 10000);
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

