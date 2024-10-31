using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public bool m_LeverSwitch = false; //レバーのフラグ
    Animator m_Animator;
    AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {        
        m_Animator.SetBool("Lever", m_LeverSwitch);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sword") && m_LeverSwitch == false)
        {
            m_LeverSwitch = true;
            m_AudioSource.Play(); //SE再生
            gameObject.tag = "Untagged";
            transform.GetChild(0).gameObject.SetActive(false); //ミニマップの表記から消す
        }
    }
}
