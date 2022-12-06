string[] GetSelectArray(string[] array, int lengthConstraint)
{
    int resultArraySize = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= lengthConstraint)
            resultArraySize++;

    string[] resultArray = new string[resultArraySize];
    int k = 0;
    for(int j = 0; j < resultArraySize; j++)
        while(k < array.Length)
        { 
            if(array[k].Length <= lengthConstraint)
            {
                resultArray[j] = array[k];
                k++;
                break;
            }
            k++;
        }

    return resultArray;
}

Console.Write("Input the size of the array of strings: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
Console.WriteLine("Input array elements:");
for(int i = 0; i < size; i++)
    array[i] = Console.ReadLine();
Console.WriteLine();

int lengthConstraint = 3;
string[] selectArray = GetSelectArray(array, lengthConstraint);

Console.WriteLine("your array of strings:");
for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "  ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"array of strings less than or equal to {lengthConstraint} characters long:");
for(int i = 0; i < selectArray.Length; i++)
    Console.Write(selectArray[i] + "  ");
Console.WriteLine();
Console.WriteLine();

