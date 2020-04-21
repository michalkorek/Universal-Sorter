using UnityEngine;

public enum SorthingAlgorithms
{
    QUICK_SORT, MERGE_SORT, SELECTION_SORT, INSERTION_SORT, BUBBLE_SORT, SHELL_SORT, IN_PLACE_MERGE_SORT, HEAP_SORT, INTRO_SORT
}

public class SortManager : MonoBehaviour
{
    public QuickSort QuickSort;
    public MergeSort MergeSort;
    public SelectionSort SelectionSort;
    public InsertionSort InsertionSort;
    public BubbleSort BubbleSort;
    public ShellSort ShellSort;
    public InPlaceMergeSort InPlaceMergeSort;
    public HeapSort HeapSort;
    public IntroSort IntroSort;

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

            case SorthingAlgorithms.BUBBLE_SORT:
                Debug.Log("BUBBLE SORT");
                break;

            case SorthingAlgorithms.SHELL_SORT:
                Debug.Log("SHELL SORT");
                break;

            case SorthingAlgorithms.IN_PLACE_MERGE_SORT:
                Debug.Log("IN PLACE MERGE SORT");
                break;

            case SorthingAlgorithms.HEAP_SORT:
                Debug.Log("HEAP SORT");
                break;

            case SorthingAlgorithms.INTRO_SORT:
                Debug.Log("INTRO SORT");
                break;
        }
    }
}
