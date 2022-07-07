Console.WriteLine("Hello, World!");

//Console.WriteLine(loneTeen(99, 20));

bool loneTeen(int aInt1, int aInt2)
{
    bool flag = true;
    if (aInt1 >= 13 && aInt1 <= 19 && aInt2 >= 13 && aInt2 <= 19)
        flag = false;
    return flag;
}

//-------------------Part2--------------------
int[] array = { 1, 2, 3, 4};

Console.WriteLine(bigDiff(array));

int bigDiff(int[] aIntArray)
{
    int small, big;
    big = findBig(aIntArray);
    small = findSmall(aIntArray);
    return big - small;
}

int findSmall(int[] aIntArray)
{
    int smallest;
    smallest = aIntArray[0];
    for(int i = 1; i < aIntArray.Length; i++)
    {
        if(smallest > aIntArray[i])
            smallest = aIntArray[i];
    }
    return smallest;
}
int findBig(int[] aIntArray)
{
    int Biggest;
    Biggest = aIntArray[0];
    for (int i = 1; i < aIntArray.Length; i++)
    {
        if (Biggest < aIntArray[i])
            Biggest = aIntArray[i];
    }
    return Biggest;
}


//------------------------Part3--------------------

//string plusOut(string aString1, string aString2)
//{
//    string result;
//    int j = 0;
//    for(int i = 0; i < aString2.Length; i++)
//    {
//        if(aString1[j + i] == aString2[i])
//        {
//            result[i] = '+';
//        }
//    }
//}