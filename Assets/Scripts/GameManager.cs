using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }
}
