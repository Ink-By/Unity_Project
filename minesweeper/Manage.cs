using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage : MonoBehaviour
{
    //프리팹
    public block CloneBlock = null;
    public int WidthBlock = 10;
    public int HeightBlock = 10;
    public int CountofMines = 10;       //지뢰의 총 개수
    public int RemineCountofMines = 0; //몇개의 지뢰가 남았는지

    public Image rocket;
    public Sprite[] rocketSprites;

    public block[,] ElementArray = null;    //2차원 배열
    
    //GridManger
    void Awake()
    {
        ElementArray = new block[WidthBlock, HeightBlock];
    }
    bool GetMineAt(int p_x,int p_y)
    {
        Debug.LogFormat("들어오긴함????");
        if ((p_x >= 0 && p_x < WidthBlock)
            && (p_y >= 0 && p_y < HeightBlock)){
            Debug.LogFormat("아니 머임" + ElementArray[p_x, p_y].IsMine);
            return ElementArray[p_x, p_y].IsMine;
        }
        return false;
    }
    public int GetRountMines(int p_x,int p_y)
    {
        int count = 0;
        //상단
        if(GetMineAt(p_x-1,p_y+1))  //왼 위
        {
            ++count;
        }
        if (GetMineAt(p_x, p_y + 1)) //바로 위
        {
            ++count;
        }
        if (GetMineAt(p_x + 1, p_y + 1)) //오른 위
        {
            ++count;
        }

        //가운데
        if (GetMineAt(p_x - 1, p_y))    //왼
        {
            ++count;
        }   
        if (GetMineAt(p_x + 1, p_y))    //오른
        {
            ++count;
        }

        //하단
        if (GetMineAt(p_x - 1, p_y - 1))
        {
            ++count;
        }
        if (GetMineAt(p_x, p_y- 1))
        {
            ++count;
        }
        if (GetMineAt(p_x + 1, p_y - 1))
        {
            ++count;
        }

        //Debug.LogFormat("" +count);
        return count;
    }
    block CloneElement(int p_x, int p_y)
    {
        block copyobj = Instantiate<block>(CloneBlock);
        copyobj.transform.SetParent(this.transform);
        copyobj.setManager(new Vector2Int(p_x, p_y), this);

        Vector3 temp = new Vector3(p_x, p_y, 0);
        copyobj.transform.localPosition = temp;
        temp.Set(15+p_x * 25, p_y * 25, 0);
        ((RectTransform)copyobj.transform).anchoredPosition = temp - new Vector3(25 * WidthBlock * .5f, 25 * HeightBlock * .5f, 0);
        copyobj.name = "clone_" + p_x.ToString() + "_" + p_y.ToString();
        return copyobj.GetComponent<block>();
    }

    void SetBomb(int xlength, int ylength,int mineCount)
    {

    }

    void GenaratorMineSweeper()
    {
        Vector3 temp = Vector3.zero;  //new Vector3();
        for (int yy = 0; yy < HeightBlock; ++yy)
        {
            for (int xx = 0; xx < WidthBlock; ++xx)
            {
                
                ElementArray[xx,yy] = CloneElement(xx, yy);
                /*copy = GameObject.Instantiate(CloneBlock.gameObject,transform);
                temp.Set(xx*25, yy*25, 0);
                ((RectTransform)copy.transform).anchoredPosition = temp - new Vector3(25 * WidthBlock * .5f,25*HeightBlock *.5f,0);
                //copy.transform.position = temp;
                //UI애서 transform 안좋음 rect transform:사각형 사용 해야함
                //
                copy.name = "CloneBlock_" + xx.ToString() + "_" + yy.ToString();*/


            }
        }

        List<block> m_tempBlockList = new List<block>();

        void SetMinesSetting()
        {
            m_tempBlockList.Clear();
            //Random.Range(0, HeightBlock);
            foreach(var item in ElementArray)
            {
                m_tempBlockList.Add(item);
            }
            int randomindex = -1;
            for(int i = 0; i < CountofMines; i++)
            {
                randomindex = Random.Range(0, m_tempBlockList.Count);
                m_tempBlockList[randomindex].SetElementDatas(true);
                m_tempBlockList.RemoveAt(randomindex);
            }
        }

        SetMinesSetting();      //지뢰 랜덤 생성

    }
    public void changeRocket(int index)
    {
        rocket.sprite = rocketSprites[index];
    }
    void Start()
    {
        // 게임 배열 생성

        GenaratorMineSweeper();
    }
}
