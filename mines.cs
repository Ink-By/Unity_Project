using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mines: MonoBehaviour
{
    public Element CloneBlock = null;
    public int WidthBlock = 10;
    public int HeightBlock = 13;

    public Element[,] ElementArray = null;
    //GridManger
    void Awake()
    {
        ElementArray = new Element[WidthBlock, HeightBlock];
    }
    void GenaratorMineSweeper()
    {
        GameObject copy = null;
        Vector3 tempps = Vector3.zero;  //new Vector3();
        for (int yy = 0; yy < HeightBlock; ++y)
        {
            for (int xx = 0; xx < WidthBlock; ++xx)
            {
                copy = GameObject.Instantiate(CloneBlock.gameObject);
                temppos.Set(xx, yy, 0);
                copy.transform.position = tempps;
                copty.name = "CloneBlock_" + xx.ToString() + "_" + yy.ToString();


            }
        }
        
    }
    void Start()
    {
        // 게임 배열 생성

        GenaratorMineSweeper();
    }
}
