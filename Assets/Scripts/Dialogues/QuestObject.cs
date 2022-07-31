using UnityEngine;
using System;


public class QuestObject : MonoBehaviour
{
    public bool IsGoodFood;
    public static event Action<bool> PickUpQuestObject; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpQuestObject?.Invoke(IsGoodFood);
            Destroy(gameObject);
        }
    }
}
