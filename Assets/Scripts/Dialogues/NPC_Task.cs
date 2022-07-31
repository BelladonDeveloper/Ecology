using UnityEngine;

public class NPC_Task : MonoBehaviour
{
    [SerializeField] private QuestSystem _dialogSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _dialogSystem.CheckQuest();
        }
    }
}
