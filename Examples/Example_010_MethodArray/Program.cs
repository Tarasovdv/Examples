﻿int[] array = { 1, 2, 52, 88, 96, 874, 22,22 };

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;

    }
    index++;
}
