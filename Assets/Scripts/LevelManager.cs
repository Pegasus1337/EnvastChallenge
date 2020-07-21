using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public GameObject LosePopup;
    public GameObject WinPopup;
    public GameObject WinPopupFirstAttempt;

    public Transform Cube1;
    public Transform Cube2;
    public Transform Cube3;

    public Transform LeftDot1;
    public Transform LeftDot2;
    public Transform LeftDot3;


    public TextMeshProUGUI ScoreText;
     



    void Update()
    {
        ScoreText.SetText("Score : " + Manager.score.ToString());
    }



    public void RepeatLevel()
    {
        
        Time.timeScale = 1;
        CountdownTimer.currentTime = 60f;
        LosePopup.SetActive(false);
        WinPopup.SetActive(false);
        Cube1.position = new Vector3(LeftDot1.position.x, LeftDot1.position.y, Cube1.position.z);
        Cube2.position = new Vector3(LeftDot2.position.x, LeftDot2.position.y, Cube2.position.z);
        Cube3.position = new Vector3(LeftDot3.position.x, LeftDot3.position.y, Cube3.position.z);
    }

    public void NextLevel()
    {
       
        Time.timeScale = 1;
        Manager.RoundNumber++;
        Manager.attempts = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
