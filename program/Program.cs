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
