using UnityEngine;

public class InPlaceMergeSort : MonoBehaviour
{
    private void Start()
    {
        int[] a = { Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100)};

        foreach (int value in a)
        {
            Debug.Log("Start array: " + value);
        }

        MergeSort(a);

        foreach (int value in a)
        {
            Debug.Log("Sorted array: " + value);
        }
    }

    static void MergeSort(int[] a)
    {
        MergeSort(a, 0, a.Length - 1);
    }

    static void MergeSort(int[] a, int s, int e)
    {
        if (s >= e)
        {
            return;
        }

        int m = (s + e) / 2;

        MergeSort(a, s, m);
        MergeSort(a, m + 1, e);
        Merge(a, s, m, e);
    }

    static void Merge(int[] a, int s, int m, int e)
    {
        int i = s, j = m + 1;

        while (i <= m && j <= e)
        {
            int step = 0;

            while (i < j && a[i] < a[j])
            {
                i++;
            }

            while (j <= e && a[i] > a[j])
            {
                j++;
                step++;
            }

            Reverse(a, i, j - step - 1);
            Reverse(a, j - step, j - 1);
            Reverse(a, i, j - 1);

            i += step;
        }
    }

    static void Reverse(int[] a, int s, int e)
    {
        int i = s, j = e;

        while (i < j)
        {
            Swap(ref a[i++], ref a[j--]);
        }
    }

    static void Swap(ref int x, ref int y)
    {
        x ^= y;
        y ^= x;
        x ^= y;
    }
}