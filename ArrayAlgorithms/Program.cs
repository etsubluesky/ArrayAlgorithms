using ArrayAlgorithms;

List<int> listOfNumber = new List<int> { 0, 1, 2, 3, 4 };


string[] names = { "Mathew", "Matt", "M", "A", "T" };
int[] numbers = { 0, 1, 2, 3, 4 };

Color[] colors = { Color.Green, Color.Blue };

//listOfNumbers.Add(8);



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
