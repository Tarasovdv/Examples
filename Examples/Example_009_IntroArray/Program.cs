﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 21, 31 };

int max = Max(array[0], array[1], array[2]);

Console.WriteLine(max);
