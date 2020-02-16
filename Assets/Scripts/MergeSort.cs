using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MergeSort : MonoBehaviour
{
    private void Main()
    {
        List<int> sortedList, unsortedList = new List<int>();

        System.Random random = new System.Random();
        
        Debug.Log("Current array:");

        for (int i = 0; i < 5; i++)
        {
            unsortedList.Add(random.Next(0, 100));
            Debug.Log(unsortedList[i]);
        }


        sortedList = MergeSortAlgorithm(unsortedList);

        Debug.Log("Sorted array:");

        foreach (int variable in sortedList)
        {
            Debug.Log(variable);
        }
    }

    private static List<int> MergeSortAlgorithm(List<int> unsorted)
    {
        if (unsorted.Count <= 1) return unsorted;

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int middle = unsorted.Count / 2;

        for (int i = 0; i < middle; i++)
        {
            left.Add(unsorted[i]);
        }

        for (int i = middle; i < unsorted.Count; i++)
        {
            right.Add(unsorted[i]);
        }

        left = MergeSortAlgorithm(left);

        right = MergeSortAlgorithm(right);

        return Merge(left, right);
    }

    private static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())  
                {
                    result.Add(left.First());

                    left.Remove(left.First());   
                }
                else
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left.First());

                left.Remove(left.First());
            }
            else if (right.Count > 0)
            {
                result.Add(right.First());

                right.Remove(right.First());
            }
        }
        return result;
    }
}
