using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public void Scene(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
}
