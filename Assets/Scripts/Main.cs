using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour 
{
    int i = 2;
    double d = 3.5;
    string s = "abc";

    void Start()
    {
        Func(1,0.5,"def");
    }

    void Func(int j, double e, string t)
    {
        Debug.Log(i + j);
        Debug.Log(d + e);
        Debug.Log(s + t);
    }
}
