using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private PlayerController m_PlayerController;
    public float m_Count = 3; //カメラのアクティブをfalseにするカウント
    // Start is called before the first frame updates
    void Start()
    {
        m_PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Count -= Time.deltaTime;
        if(m_Count < 0)
        {
            Destroy(gameObject);
            m_PlayerController.enabled = true;
        }
        else
        {
            m_PlayerController.enabled = false;
        }
    }
}
