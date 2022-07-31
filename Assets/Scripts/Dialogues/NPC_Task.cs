using UnityEngine;

public class NPC_Task : MonoBehaviour
{
    [SerializeField] private QuestSystem _dialogSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;

            _dialogSystem.CheckQuest();
        }
    }
}
