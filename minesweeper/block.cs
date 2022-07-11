using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class block : MonoBehaviour
{
    public Sprite[] ChangeSprite = null;
    private Image images = null;
    public Manage GridLinkManager = null;

    [SerializeField]
    private bool m_isMine = false;
    private Vector2Int coord;


    public bool IsMine { 
        
        get => m_isMine; 
        protected set => m_isMine = value; }
    private Manage manage = null; 

    public void SetElementDatas(bool p_ismine)
    {
        m_isMine = p_ismine;
    }
    void SetChangeTexture(int index)
    {
        images.sprite = ChangeSprite[index];
    }
    // Start is called before the first frame update
    void Start()
    {
        images = this.GetComponent<Image>();
        GridLinkManager = GameObject.FindObjectOfType<Manage>();
        // Ȯ�ο�
        

    }
    public void click()  //��ư�� ������ ��
    {
        Debug.LogFormat("Ŭ�� Ȯ��");

        if (m_isMine)
        {
            SetChangeTexture(9);

            if(manage != null)
                manage.changeRocket(1);
            
            //���� ����
        }
        else
        {

            SetChangeTexture(GridLinkManager.GetRountMines(coord.x, coord.y));

        }
    }

    private void OnDrawGizmos()
    {
        if (m_isMine)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(this.transform.position, new Vector3(5f, 5f, 0));
        }
    }

    public void setManager(Vector2Int coord, Manage manage)
    {
        this.coord = coord;
        this.manage = manage;
    }
}