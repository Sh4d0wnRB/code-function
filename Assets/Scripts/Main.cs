using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public int a = 1;
    public int b = 1;
    public int c = 1;

    void Start()
    {
        BaskharaL1(a, b, c);
    }
    #region treino
    private void Soma(int x, int y)
    {
        Debug.Log(x + y);
    }
    private int Soma3(int x, int y, int z)
    {
        return x + y + z;
    }
    private void Media(int x, int y, int z)
    {
        int result = Soma3(x , y, z);
        Debug.Log((result) / 3);
    }
    #endregion

    #region exercicios
    private int Delta(int a, int b, int c)
    {
        return (b * b) - 4 * a * c;
    }
    private void BaskharaL1(int a, int b, int c)
    {
        int delta = Delta(a, b, c);
        Debug.Log((-b - Mathf.Sqrt(delta))/ 2 * a);
        Debug.Log((-b + Mathf.Sqrt(delta)) / 2 * a);
    }
    #endregion
}
