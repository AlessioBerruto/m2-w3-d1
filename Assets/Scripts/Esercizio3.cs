using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{

    public int dimensione = 10;
    public int min = 1;
    public int max = 20;
    private int minimo = 0;
    private int massimo = 0;

    void Start()
    {
        int[] array = GeneraArray(dimensione, min, max);
        StampaArray(array);
        minimo = TrovaMinimo(array);
        Debug.Log("il numero minimo è: " + minimo);
        massimo = TrovaMassimo(array);
        Debug.Log("il numero massimo è: " + massimo);

        TrovaMinimi2(array);
        TrovaMassimi2(array);
    }

    void Update()
    {

    }

    public int[] GeneraArray(int dimensione, int min, int max)
    {
        int[] array = new int[dimensione];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max + 1);
        }

        return array;

    }

    void StampaArray(int[] array)
    {
        string stampa = string.Join(", ", array);
        Debug.Log(stampa);
    }

    int TrovaMinimo(int[] array)
    {
        int minimo = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }

        return minimo;
    }

    int TrovaMassimo(int[] array)
    {
        int massimo = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > massimo)
            {
                massimo = array[i];
            }
        }

        return massimo;
    }

    void TrovaMinimi2(int[] array)
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min1)
            {
                min2 = min1;
                min1 = array[i];
            }
            else if (array[i] >= min1 && array[i] <= min2)
            {
                min2 = array[i];
            }
        }

        Debug.Log("I due numeri più bassi sono: " + min1 + " e " + min2);

    }

    void TrovaMassimi2(int[] array)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max1)
            {
                max2 = max1;
                max1 = array[i];
            }
            else if (array[i] <= max1 && array[i] >= max2)
            {
                max2 = array[i];
            }
        }

        Debug.Log("I due numeri più alti sono: " + max1 + " e " + max2);

    }

}

