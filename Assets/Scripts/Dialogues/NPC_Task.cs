﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour
{
    public bool end_Dialogue;
    public GameObject dialogue;
    public GameObject dialogue2;
    public Quests QE;
    public bool findial;
    public GameObject particles;
    


    // Update is called once per frame
    void Update()
    {
        if(end_Dialogue == true)
        {

            Time.timeScale = 1;
            QE.Quest1 = true;
            dialogue.SetActive(false);
            particles.SetActive(true);

        }
        if(findial == true)
        {
            //Time.timeScale = 1;
            QE.Quest1 = false;
            dialogue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Time.timeScale = 0;
            if(QE.endQuest1 == false)
            {
                dialogue.SetActive(true);
            }
            else
            {
                dialogue2.SetActive(true);
            }
            
        }
    }
}
