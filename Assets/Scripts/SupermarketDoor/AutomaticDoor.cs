using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutomaticDoor : MonoBehaviour
{
   public Animation doorOpen;
   
    private void OnTriggerEnter(Collider other)
    {
        doorOpen.Play("Door_Animation");
        Debug.Log("111");
    }

     void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
