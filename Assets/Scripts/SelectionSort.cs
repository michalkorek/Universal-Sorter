using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    private void Main()
    {
        int[] array = new int[5] { Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100)};
        int temp, smallest, n = array.Length;

        Debug.Log("Init array:");

        for (int i = 0; i < n; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 0; i < n - 1; i++)
        {
            smallest = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[smallest])
                {
                    smallest = j;
                }
            }

            temp = array[smallest];

            array[smallest] = array[i];

            array[i] = temp;
        }


        Debug.Log("Sorted aray:");

        for (int i = 0; i < n; i++)
        {
            Debug.Log(array[i]);
        }
    }
}
