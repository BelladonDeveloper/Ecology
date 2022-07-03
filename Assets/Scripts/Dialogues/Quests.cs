using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    public bool Quest1;
    public GameObject Text1;
    public bool endQuest1;
    public int Counter = 0;
    public int MaxCount = 10;

    private void Start()
    {
        QuestObject.PickUpQuestObject += CheckNumberObjects;
    }

    void CheckNumberObjects(bool isGoodFood)
    {
        if (isGoodFood)
        {
            Counter++;

            if (Counter == MaxCount)
            {
                QuestObject.PickUpQuestObject -= CheckNumberObjects;
                endQuest1 = true;
            }
        }
    }

    void Update()
    {
        if(endQuest1 == false)
        {
            if (Quest1 == true)
            {
                Text1.SetActive(true);
            }
            else
            {
                Text1.SetActive(false);
            }
        }
        else
        {
            Text1.SetActive(false);
        }
        
    }


    private void OnDestroy()
    {
        QuestObject.PickUpQuestObject -= CheckNumberObjects;

    }
}
