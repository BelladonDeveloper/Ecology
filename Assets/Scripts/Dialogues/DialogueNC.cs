using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNC : MonoBehaviour
{
    public NPC_Task npc_task;
    public GameObject Text1;
    public GameObject Text2;
    public bool enddial;
    public GameObject QuestObject;
    


    private bool isText1 = true;
    
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(isText1 == true)
            {
                isText1 = false;
            }
            else
            {
                if(enddial == false)
                {
                    isText1 = true;
                    QuestObject.SetActive(true);
                    npc_task.end_Dialogue = true;
                }
                else
                {
                    
                    isText1 = true;
                }
                
            }
        }
        if(isText1 == true)
        {
            Text1.SetActive(true);
            Text2.SetActive(false);
           
        }
        else
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
            
        }
        

    }
}
