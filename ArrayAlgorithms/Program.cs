/*using ArrayAlgorithms;

List<int> listOfNumber = new List<int> { 0, 1, 2, 3, 4 };


string[] names = { "Mathew", "Matt", "M", "A", "T" };
int[] numbers = { 0, 1, 2, 3, 4 };

Color[] colors = { Color.Green, Color.Blue };

//listOfNumbers.Add(8);



var someCollection = CollectOfClassGenerator<Person>(25);
var someCollection1 = CollectOfClassGenerator<SomeOtherClass>(25);

someCollection[0].FirstName = "Mathew";
someCollection[0].LastName = "Desjardins";

someCollection1[0].Num = 1;
someCollection1[0].IDontCare = "WhatEver!";
*/
using System.Xml;

int[,] twoD = new int[4,4];

twoD[0, 0] = 1;
twoD[1, 0] = 2;
twoD[2, 0] = 3;
twoD[3, 0] = 4;
twoD[0, 1] = 5;
twoD[1, 1] = 6;
twoD[2, 1] = 7;
twoD[3, 1] = 8;
twoD[0, 2] = 9;
twoD[1, 2] = 10;
twoD[2, 2] = 11;
twoD[3, 2] = 12;
twoD[0, 3] = 13;
twoD[1, 3] = 14;
twoD[2, 3] = 15;
twoD[3, 3] = 16;

Console.WriteLine("This how many elements there are! " + twoD.Length);
Console.WriteLine("This is the dimmension of the array! " + twoD.Rank);
Console.WriteLine("This will get the number of columns! "+ twoD.GetLength(0));
Console.WriteLine("This is the height of the array! " + twoD.GetLength(1));

string holder = "-----------------------------------------------------------------\n";
for (int  y = 0; y < twoD.GetLength(0); y++)
{
    holder += "|\t";
    for (int x = 0; x < twoD.GetLength(1); x++)
    {
        holder += + twoD[x,y] + "\t|\t";
    }

    holder += "\n";
    holder += "-----------------------------------------------------------------";
    holder += "\n";
}

Console.WriteLine(holder);

/*
foreach (var item in numbers)
{
    Console.WriteLine(item);

}


Console.WriteLine("\n\n\n\n");

numbers =Insert<int>(numbers, 34, 6);


foreach (var item in numbers)
{
    Console.WriteLine(item);

}

Console.WriteLine("\n\n\n\n");

numbers = Remove<int>(numbers);


foreach (var item in numbers)
{
    Console.WriteLine(item);

}



T[] AddOneToTheEnd<T>(T[] orginal, T whatToAddToTheEnd)
{
    T[] toReturn = new T[orginal.Length + 1];

    for (int i = 0; i < orginal.Length; i++)
    {
        toReturn[i] = orginal[i];
    }

    toReturn[toReturn.Length - 1] = whatToAddToTheEnd;

    return toReturn;
}

bool AmIAValidEnum<T>(T[] enums, int num) where T: Enum
{

        return enums.GetType().Equals(enums[num].GetType());
    

}

//remove

T[] Remove<T>(T[] orginal)
{
    T[] toReturn = new T[orginal.Length - 1];

    for (int i = 0; i < toReturn.Length; i++)
    {
        toReturn[i] = orginal[i];
    }

    return toReturn;
}

T[] Insert<T>(T[] orginal, T whatToInsert, int index)
{
    T[] toReturn= new T[orginal.Length + 1];

    index--;


    for (int i = 0; i < index; i++)
    {
        toReturn[i] = orginal[i];
    }

    toReturn[index] = whatToInsert;

    for (int i = index + 1;  i < toReturn.Length ; i++)
    {
        toReturn[i] = orginal[i - 1];
    }

    return toReturn;
}

T[] CollectOfClassGenerator<T>(int howMany) where T : new()
{
    T[] toReturn =new T[howMany];

    for (int i = 0; i < toReturn.Length; i++)
    {
        toReturn[i] = new T();
    
    }

    return toReturn;
}
*/