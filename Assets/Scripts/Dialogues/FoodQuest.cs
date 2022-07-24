using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodQuest : MonoBehaviour
{
    [SerializeField] private QuestSystem _questSystem;

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

                _questSystem.ChangeState(QuestSystem.QuestState.Complete);
            }
        }
    }


    private void OnDestroy()
    {
        QuestObject.PickUpQuestObject -= CheckNumberObjects;
    }
}
