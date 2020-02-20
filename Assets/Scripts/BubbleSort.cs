using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    private void Main()
    {
        int[] array = { Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100) };

        Debug.Log("Current Array");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        int temp;

        for (int j = 0; j <= array.Length - 2; j++)
        {
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
        }

        Debug.Log("Sorted:");

        foreach (int p in array)
            Debug.Log(p);
    }
}
