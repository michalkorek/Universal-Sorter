using UnityEngine;

public enum SorthingAlgorithms
{
    QUICK_SORT, MERGE_SORT, SELECTION_SORT, INSERTION_SORT, BUBBLESORT
}

public class SortManager : MonoBehaviour
{
    public QuickSort QuickSort;
    public MergeSort MergeSort;
    public SelectionSort SelectionSort;
    public InsertionSort InsertionSort;
    public BubbleSort BubbleSort;

    public SorthingAlgorithms sorthingAlgorithms;

    private void OnValidate()
    {
        switch (sorthingAlgorithms)
        {
            default:
                Debug.Log("NOTHING");
                break;

            case SorthingAlgorithms.QUICK_SORT:
                Debug.Log("QUICK SORT");
                break;

            case SorthingAlgorithms.MERGE_SORT:
                Debug.Log("MERGE SORT");
                break;

            case SorthingAlgorithms.SELECTION_SORT:
                Debug.Log("SELECTION SORT");
                break;

            case SorthingAlgorithms.INSERTION_SORT:
                Debug.Log("INSERTION SORT");
                break;

            case SorthingAlgorithms.BUBBLESORT:
                Debug.Log("BUBBLE SORT");
                break;
        }
    }
}
