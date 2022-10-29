using Practice_Matrices;

Matr m = new Matr("C:/Users/minda/Desktop/aaa.txt");
InMatr n = new InMatr(m);
SQMatr s = new SQMatr(1);
m.show();
n.Inverce().show();
(n.Inverce() * m).show();