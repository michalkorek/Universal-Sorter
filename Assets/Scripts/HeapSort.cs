using UnityEngine;

public class HeapSort : MonoBehaviour
{
    private void Start()
    {
        int[] array = { Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100) };

        Debug.Log("Heap Sort");

        foreach (int value in array)
        {
            Debug.Log(value);
        }

        Sort(array);

        Debug.Log("Sorted");

        foreach (int value in array)
        {
            Debug.Log(value);
        }
    }

    private void Sort(int[] array)
    {
        var length = array.Length;

        for (int i = length / 2 - 1; i >= 0; i--)
        {
            Heapify(array, length, i);
        }

        for (int i = length - 1; i >= 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            Heapify(array, i, 0);
        }
    }

    private void Heapify(int[] array, int length, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < length && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < length && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;
            Heapify(array, length, largest);
        }
    }
}