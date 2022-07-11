using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2 : MonoBehaviour
{
    /*public GameObject[,] blockArray = new GameObject[10, 10];
    public int[,] blockStateArray = new int[10, 10];    //블록의 배열
    public bool[,] blockCheckArray = new bool[10, 10];  //블록이 지뢰인지 아닌지 체크

    public Sprite[] blockSprites;
    bool isGameOvered;
    public GameObject winText;

    private void Awake()
    {
        
            int temp1;
            int temp2;
        for(int i = 0; i < 10; i++)
        {
            do
            {
                temp1 = Random.Range(1, 9);
                temp2 = Random.Range(1, 9);
            } while (blockStateArray[temp1, temp2] == 10);  //지뢰 위치 지정
            blockStateArray[temp1, temp2] = 10;
        }
        for(int i = 1; i < 9; i++)
        {
            for(int j = 1; j < 9; j++)
            {
                if(blockStateArray[i,j] != 10)
                {
                    int minCount = 0;
                    if (blockStateArray[i - 1, j - 1] == 10)
                    {
                        minCount++;
                    }
                    if(blockStateArray[])
                }
            }
        }
    }*/
    //블럭의 이미지를 바꾸는 코드
    public Sprite[] ChangeSprite = null;
    private SpriteRenderer m_SpriteRenderer = null;
    void SetChangeTexture(int index)
    {
        m_SpriteRenderer.sprite = ChangeSprite[index];
    }
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = this.GetComponent<m_SpriteRenderer>();
        // 확인용
        //SetChangeTexture(0);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
