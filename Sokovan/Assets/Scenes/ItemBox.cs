using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;
    public Color touchColor;
    private Color originColor;

    public bool isOveraped = false;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        
    }

    // 트리거인 콜라이더와 충돌할 때 자동으로 실행
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = Color.blue;
            //Debug.Log("EndPOint 도달");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originColor;
            //Debug.Log("EndPOint 도달");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
           // Debug.Log("EndPOint 도달");
        }
    }

    // 일반 콜라이더와 충돌했을 때 자동으로 실행
    /*void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌했음");
    }*/
}
