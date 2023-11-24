// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

Console.WriteLine(a);
Span<int> b = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];

int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[] twoDFromVariables = [.. row0, .. row1, .. row2];

Dictionary<string, int> dic = [];