using UnityEngine;

public class InsertionSort : MonoBehaviour
{
    private void Main()
    {
        int[] array = new int[5] { Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100) };
        int n = array.Length, i, j, val, flag;

        Debug.Log("Insertion Sort");
        Debug.Log("Initial array");

        for (i = 0; i < n; i++)
        {
            Debug.Log(array[i] + " ");
        }

        for (i = 1; i < n; i++)
        {
            val = array[i];
            flag = 0;

            for (j = i - 1; j >= 0 && flag != 1;)
            {
                if (val < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = val;
                }
                else flag = 1;
            }
        }

        Debug.Log("Sorted Array");
        for (i = 0; i < n; i++)
        {
            Debug.Log(array[i]);
        }
    }     
}
