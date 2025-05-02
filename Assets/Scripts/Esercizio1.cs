using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int number = 0;
    private bool even = false;
    public int base_ = 1;
    public int multiple = 1;
    private bool res = false;

    void Start()
    {
        even = isEven(number, even);

        if (even == true)
        {
            Debug.Log("il numero " + number + " è pari");
        }
        else
        {
            Debug.Log("il numero " + number + " è dispari");
        }

        res = isMultipleOf(base_, multiple, res);

        if (res == true)
        {
            Debug.Log("il numero " + multiple + " è multiplo del numero " + base_);
        }
        else
        {
            Debug.Log("il numero " + multiple + " non è multiplo del numero " + base_);
        }
    }

    void Update()
    {

    }

    bool isEven(int number, bool even)
    {
        if (number % 2 == 0)
        {
            even = true;
        }
        else
        {
            even = false;
        }

        return even;
    }

    bool isMultipleOf(int base_, int multiple, bool res)
    {
        if (multiple % base_ == 0)
        {
            res = true;
        }
        else
        {
            res = false;
        }

        return res;
    }
}
