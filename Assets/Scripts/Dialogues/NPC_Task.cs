using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Task : MonoBehaviour
{
    public bool end_Dialogue;
    public GameObject dialogue;
    public GameObject dialogue2;
    public Quests QE;
    public bool findial;

    void Update()
    {
        if (end_Dialogue == true)
        {
            Time.timeScale = 1;
            QE.Quest1 = true;
            dialogue.SetActive(false);

        }
        if (findial == true)
        {
            Time.timeScale = 1;
            QE.Quest1 = false;
            dialogue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            if (QE.endQuest1 == false)
            {
                dialogue.SetActive(true);
            }
            else
            {
                dialogue2.SetActive(true);

                //SceneManager.LoadScene(1);

                print("Finish quest )");
            }
        }
    }
}
