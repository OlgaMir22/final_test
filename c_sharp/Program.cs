/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string [] filterStringArrayByLength ( string [] strings, int maxLength = 3 )
{
    string [] result = new string [strings.GetLength ( 0 )];

    int j = 0;
    for ( int i = 0; i < strings.GetLength ( 0 ); ++i )
    {
        if ( strings [i].Length <= maxLength )
        {
            result [j] = strings [i];
            ++j;
        }
    }

    return result;
}

void printArray ( string [] strings )
{
    int actual_len = 0;
    for ( int i = 0; i < strings.GetLength ( 0 ); ++i )
    {
        if ( !String.IsNullOrEmpty ( strings [i] ) )
            ++actual_len;
        else
            break;
    }

    if ( actual_len == 0 )
    {
        Console.Write ( "[]" );
        return;
    }

    Console.Write ( "[" );
    for ( int i = 0; i < actual_len - 1; ++i )
        Console.Write ( $"\"{strings [i]}\", " );

    Console.Write ( $"\"{strings [actual_len - 1]}\"" );
    Console.Write ( "]" );
}

Console.WriteLine ( "Final test program by Olga Miroshnichenko" );
Console.Write ( "Input number of strings in array (-1 to fill with default values): " );
int N = Convert.ToInt32 ( Console.ReadLine () );

string [] array = { "1234", "1567", "-2", "computer science" };

if ( N >= 0 )
{
    array = new string [N];
    for ( int i = 0; i < array.GetLength ( 0 ); ++i )
    {
        Console.Write ( $"Input array item {i}: " );
        array [i] = Console.ReadLine ().ToString ();
    }
}
    
string [] result = filterStringArrayByLength ( array );

printArray ( array );
Console.Write ( " -> " );
printArray ( result );