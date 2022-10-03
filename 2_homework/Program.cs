// See https://aka.ms/new-console-template for more information
using Practice2;

coord a = new coord(1, 1, 1);
coord b = new coord(2, 2, 2);
coord c = new coord(3, 3, 3);
coord d = new coord(1, 0, 0);

a.show();
Console.WriteLine(coord.Dist(a, b));
coord.Equasion2D(a, b);
coord.Equasion3D(a, b, d);
Console.WriteLine(coord.DistBeg(a));
(a+d).show();
Console.WriteLine(a * b);
coord.VectMult(a, d);

