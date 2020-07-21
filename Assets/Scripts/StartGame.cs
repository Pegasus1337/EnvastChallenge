using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void InitiateGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public  void ExitGame()
    {
        Application.Quit();
    }

}
