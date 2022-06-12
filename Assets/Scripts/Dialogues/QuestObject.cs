using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class QuestObject : MonoBehaviour
{
    public Quests QEvent;
    public static event Action PickUpQuestObject; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpQuestObject?.Invoke();
            Destroy(gameObject);
        }
    }
}
