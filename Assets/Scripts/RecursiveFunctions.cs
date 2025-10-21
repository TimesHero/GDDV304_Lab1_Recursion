using UnityEngine;

public class RecursiveFunctions : MonoBehaviour
{
    public int fibonacciNumber = 5;
    public int factorialNumber = 5;

    void Start()
    {
        Debug.Log($"Fibonacci: {FibonacciSequence(fibonacciNumber)}.");
        Debug.Log($"{CountAllChildren(transform)} children.");
        Debug.Log($"Factorial: {Factorial(factorialNumber)}.");
    }

    private int FibonacciSequence(int n)
    {
        // If n is less than 2, then return n.
        if (n < 2)
        {
            return n;
        }
        // Return the result of FibonacciSequence of n - 1 plus the result of FibonacciSequence of n - 2.
        else
        {
            return FibonacciSequence(n-1) + FibonacciSequence(n-2);
        }
    }

    private int CountAllChildren(Transform parent)
    {
        // Declare a new integer called total and set it to 0.
        int total = 0;
        // Iterate through the children of parent
        for (int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            total += 1;
            total += CountAllChildren(child);
        }
        // return total
        return total;

    }

    private int Factorial(int n)
    {
        // if n is less than or equal to 1
        // return 1
        if (n <= 1)
        {
            return 1;
        }
        // return n multiplied but the result of n-1! (that is, the factorial of n-1).
        else
        {
            return n * Factorial(n - 1);
        }
    }
}