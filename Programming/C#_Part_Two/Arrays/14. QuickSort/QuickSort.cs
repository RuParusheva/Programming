//Task 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSort
{

    public static void QuickSwap(string[] array, int left, int right)
    {
        string temp = array[right];
        array[right] = array[left];
        array[left] = temp;
    }

    public static void Sort(string[] array, int left, int right)
    {
        int lHold = left;
        int rHold = right;
        Random objRan = new Random();
        int pivot = objRan.Next(left, right);
        QuickSwap(array, pivot, left);
        pivot = left;
        left++;

        while (right >= left)
        {
            int compareLeftVal = array[left].CompareTo(array[pivot]);
            int compareRightVal = array[right].CompareTo(array[pivot]);

            if ((compareLeftVal >= 0) && (compareRightVal < 0))
            {
                QuickSwap(array, left, right);
            }
            else
            {
                if (compareLeftVal >= 0)
                {
                    right--;
                }
                else
                {
                    if (compareRightVal < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                        left++;
                    }
                }
            }
        }
        QuickSwap(array, pivot, right);

        pivot = right;
        if (pivot > lHold)
        {
            Sort(array, lHold, pivot);
        }
        if (rHold > pivot + 1)
        {
            Sort(array, pivot + 1, rHold);
        }
    }
    public static void Print(string[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string[] myArrayOne = new string[] { "if", "else", "with", "about", "on", "before", "without" };

        Sort(myArrayOne, 0, myArrayOne.Length - 1);
        Print(myArrayOne);
    }
}

