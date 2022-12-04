using Matrices_other;
using System.Collections;
matr<int> A = new matr<int>(4, 5);

A[2, 2] = 1;
A[0, 2] = 2;
A[0, 3] = 3;
A[3, 4] = 4;
A[1, 2] = 5;
A[0, 0] = 5;
A.show();
A.sq(0, 3).show();


Dictionary<int[], int> B = new Dictionary<int[], int>(new MyEqualityComparer());
int[] a = new int[] {1, 1 };
int[] b = new int[] { 1, 1 };
B[a] = 1;
Console.WriteLine(B[b]);