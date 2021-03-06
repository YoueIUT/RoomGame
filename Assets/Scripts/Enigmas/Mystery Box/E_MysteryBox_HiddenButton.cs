﻿using UnityEngine;
using System.Collections;

public class E_MysteryBox_HiddenButtonAttribute : EnigmaAttributes
{

}
public class E_MysteryBox_HiddenButton : ActivableObject {


    [SerializeField]
    GameObject m_hiddenContainer;
    [SerializeField]
    GameObject m_hiddenKey;
    [SerializeField]
    Transform m_keySpawnPoint;
  
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	

    protected override void specificActivation()
    {
        //base.OnLoadAttributes();
        if (!m_isActivated)
        {
            m_hiddenKey.transform.position = m_keySpawnPoint.position;
            m_keySpawnPoint.gameObject.GetComponent<AudioSource>().Play(); 
        }
        m_hiddenKey.GetComponent<Rigidbody>().isKinematic = false;
        m_hiddenContainer.SetActive(false);

    }

    

}
