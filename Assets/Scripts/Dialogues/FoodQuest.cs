using UnityEngine;

public class FoodQuest : MonoBehaviour
{
    [SerializeField] private QuestSystem _questSystem;

    [SerializeField] private int Counter = 0;
    [SerializeField] private int MaxCount = 10;

    private void Start()
    {
        QuestObject.PickUpQuestObject += CheckNumberObjects;
    }

    private void CheckNumberObjects(bool isGoodFood)
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

    public int GetQualityGoodFood() => Counter;

    private void OnDestroy() => QuestObject.PickUpQuestObject -= CheckNumberObjects;
}
