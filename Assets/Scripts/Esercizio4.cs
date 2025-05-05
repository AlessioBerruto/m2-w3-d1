using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int dim = 10;
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };

        array = CambiaDimensioneArray(array, dim);

        string stampaArray = string.Join(", ", array);
        Debug.Log(stampaArray);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int[] CambiaDimensioneArray(int[] array, int dim)
    {
        if (dim == array.Length)
        {
            return array;
        }

        int[] arr = new int[dim];

        for (int i = 0; i < Mathf.Min(array.Length, dim); i++)
        {
            arr[i] = array[i];            
        }

        return arr;
    }
}
