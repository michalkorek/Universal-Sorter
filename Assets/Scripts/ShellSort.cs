using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSort : MonoBehaviour
{
    private void Start()
    {
        int[] arr = new int[] { Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100) };
        int n;

        n = arr.Length;
        
        Debug.Log("Original Array Elements");
        ShowArrayElements(arr);

        ShellSortAlgorithm(arr, n);

        Debug.Log("Sorted Array Elements");
        ShowArrayElements(arr);
    }

    private void ShellSortAlgorithm(int[] arr, int array_size)
    {
        int i, j, inc, temp;

        inc = 3;

        while (inc > 0)
        {
            for (i = 0; i < array_size; i++)
            {
                j = i;
                temp = arr[i];

                while ((j >= inc) && (arr[j - inc] > temp))
                {
                    arr[j] = arr[j - inc];
                    j -= inc;
                }

                arr[j] = temp;
            }

            if (inc / 2 != 0)
                inc /= 2;
            else if (inc == 1)
                inc = 0;
            else
                inc = 1;
        }
    }

    private void ShowArrayElements(int[] arr)
    {
        foreach (var element in arr)
        {
            Debug.Log(element);
        }
    }
}
