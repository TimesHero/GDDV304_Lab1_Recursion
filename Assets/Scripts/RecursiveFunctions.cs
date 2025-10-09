using UnityEngine;

public class RecursiveFunctions : MonoBehaviour
{
    public int fibonacciNumber = 5;
    public int factorialNumber = 5;

    void Start()
    {
        Debug.Log(FibonacciSequence(fibonacciNumber));
        Debug.Log(CountAllChildren(transform));
        Debug.Log(Factorial(factorialNumber));
    }

    private int FibonacciSequence(int n)
    {
        // If n is less than 2, then return n.
        // Return the result of FibonacciSequence of n - 1 plus the result of FibonacciSequence of n - 2.

        return -1; // ← remove this
    }

    private int CountAllChildren(Transform parent)
    {
        // Declare a new integer called total and set it to 0.

        // Iterate through the children of parent
        // Add to total 1 plus the result of counting current child's children.

        // return total

        return -1; // ← remove this
    }

    private int Factorial(int n)
    {
        // if n is less than or equal to 1
        // return 1

        // return n multiplied but the result of n-1! (that is, the factorial of n-1).
        
        return -1; // ← remove this
    }
}