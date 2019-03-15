using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Main2 : MonoBehaviour
{
	void Start () 
    {
        Seila(12, 20, 8);
	}

    void Seila(double CustoRefeicao, int percGorgeta, int percImposto)
    {
        double Gorgeta = (int) CustoRefeicao * ((double) percGorgeta / 100);
        double Imposto = (int) CustoRefeicao * ((double) percImposto / 100);

        double CustoTotal = CustoRefeicao + Gorgeta + Imposto;
        Debug.Log(Math.Round(CustoTotal));
    }
}
