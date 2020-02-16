using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Quick Sort algorithm
/// </summary>

public class QuickSort : MonoBehaviour
{
    private void Main()
    {
        int[] randomArray = new int[] { Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100)};

        Debug.Log("Current array:");

        foreach (var variable in randomArray)
        {
            Debug.Log(variable);
        }


        QuickSortAlgorithm(randomArray, 0, randomArray.Length - 1);

        Debug.Log("Sorted array:");

        foreach (var variable in randomArray)
        {
            Debug.Log(variable);
        }
    }

    private void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);

            if (pivot > 1)
            {
                QuickSortAlgorithm(array, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSortAlgorithm(array, pivot + 1, right);
            }
        }

    }

    private int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];

        while (true)
        {
            while (array[left] < pivot)
            {
                left++;
            }

            while (array[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (array[left] == array[right]) return right;

                int temp = array[left];

                array[left] = array[right];

                array[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}
