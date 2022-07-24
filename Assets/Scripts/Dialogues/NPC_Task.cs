using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Task : MonoBehaviour
{
    public bool end_Dialogue;
    public GameObject dialogue;
    public GameObject dialogue2;
    public FoodQuest QE;
    public bool findial;

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
