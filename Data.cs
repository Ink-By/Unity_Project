using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    /*public GameObject[,] blockArray = new GameObject[10, 10];
    public int[,] blockStateArray = new int[10, 10];    //����� �迭
    public bool[,] blockCheckArray = new bool[10, 10];  //����� �������� �ƴ��� üũ

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
            } while (blockStateArray[temp1, temp2] == 10);  //���� ��ġ ����
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
    //���� �̹����� �ٲٴ� �ڵ�
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
        // Ȯ�ο�
        //SetChangeTexture(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
