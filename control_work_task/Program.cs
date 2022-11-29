using System;
using static System.Console;

string[] array = AskArray();
string[] result = FindLess(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLess(string[] input, int n) 
{
    string[] output = new string[CountLess(input, n)];

    for(int i = 0, a = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) {
            output[a] = input[i];
            a++;
        }
    }

    return output;
}

int CountLess(string[] input, int n) 
{
    int count = 0;
    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] AskArray() 
{
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}