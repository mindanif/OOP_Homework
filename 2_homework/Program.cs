// See https://aka.ms/new-console-template for more information
using Practice2;

Coord a = new Coord(1,0,0);
Coord b = new Coord(1,1, 0);
Coord c = new Coord(0,1,0);
Coord d = new Coord(0,0,0);

Coord a1 = new Coord(0, 0, 0);
Coord b1 = new Coord(-1, 0, 0);
Coord c1 = new Coord(1, 1, 0);
Coord d1 = new Coord(0, -1, 0);

Dots QR = new Dots(a1,b1,c1,d1);



Console.WriteLine(Dots.S(QR));
Console.WriteLine(Dots.P(QR));
Console.WriteLine(Dots.Diagon(QR)[1]);
Console.WriteLine(Dots.Convex(QR));






