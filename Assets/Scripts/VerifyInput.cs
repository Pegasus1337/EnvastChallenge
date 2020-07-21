using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VerifyInput : MonoBehaviour
{
    // Number of Rounds user is allowed to play 
    const int NB_ROUNDS = 10;

    // Correct Sprites and their names stored in DisplayElements Array 

    private string CorrectName1 = Manager.DisplayedElementsNames[0];
    private string CorrectName2 = Manager.DisplayedElementsNames[1];
    private string CorrectName3 = Manager.DisplayedElementsNames[2];

    //Reference to WinPopupFirstAttempt 
    public GameObject WinPopupFirstAttempt;
    public GameObject WinPopup;
    public GameObject LosePopup;
    public GameObject GameCompletedPopup;

    public WinStars winstars; 
    //Function to check whether user input was indeed successfull or not     
    public void CheckInput()
    {
        Time.timeScale = 0;
        // Debugging Data 

        /* Debug.Log(CheckBox1.BoxPosition);
         Debug.Log(CheckBox2.BoxPosition);
         Debug.Log(CheckBox3.BoxPosition);
         Debug.Log(Manager.ShuffeledNames[0]);
         Debug.Log(Manager.ShuffeledNames[1]);
         Debug.Log(Manager.ShuffeledNames[2]);
         Debug.Log(Manager.DisplayedElementsNames[0]);
         Debug.Log(Manager.DisplayedElementsNames[1]);
         Debug.Log(Manager.DisplayedElementsNames[2]); */


        bool correct = true;
        Manager.attempts++;
        if (CheckBox1.BoxPosition == "Answer1")
        {
            if (Manager.ShuffeledNames[0] == Manager.DisplayedElementsNames[0])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        else if (CheckBox1.BoxPosition == "Answer2")
        {
            if (Manager.ShuffeledNames[1] == Manager.DisplayedElementsNames[0])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        else if (CheckBox1.BoxPosition == "Answer3")
        {
            if (Manager.ShuffeledNames[2] == Manager.DisplayedElementsNames[0])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }

        //

        if (CheckBox2.BoxPosition == "Answer1")
        {
            if (Manager.ShuffeledNames[0] == Manager.DisplayedElementsNames[1])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        else if (CheckBox2.BoxPosition == "Answer2")
        {
            if (Manager.ShuffeledNames[1] == Manager.DisplayedElementsNames[1])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        else if (CheckBox2.BoxPosition == "Answer3")
        {
            if (Manager.ShuffeledNames[2] == Manager.DisplayedElementsNames[1])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }

        //

        if (CheckBox3.BoxPosition == "Answer1")
        {
            if (Manager.ShuffeledNames[0] == Manager.DisplayedElementsNames[2])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        else if (CheckBox3.BoxPosition == "Answer2")
        {
            if (Manager.ShuffeledNames[1] == Manager.DisplayedElementsNames[2])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        else if (CheckBox3.BoxPosition == "Answer3")
        {
            if (Manager.ShuffeledNames[2] == Manager.DisplayedElementsNames[2])
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }

        if ((correct == true)&&(Manager.RoundNumber < NB_ROUNDS-1))
        {
            Debug.Log("Correct Answer");
            //Initiate Success Popup
            Win(Manager.attempts);
            
        }
        else if ((correct == true)&&(Manager.RoundNumber == NB_ROUNDS-1))
        {
            
            Manager.AssignStarsNdScore(Manager.score);
            GameCompletedPopup.SetActive(true);
        }else
        {
            Debug.Log("Wrong Answer");
            //Initiate Lose Popup
            Lose();
        }

    }



    void Win(int nbAttempts)
    {
        Time.timeScale = 0;
        winstars.AssignStars(Manager.attempts);
        Manager.AssignStarsNdScore(Manager.attempts);
        if (nbAttempts == 1)
        {
            WinPopupFirstAttempt.SetActive(true);
        }
        else
        {
            WinPopup.SetActive(true);

        }
        
    }

     void Lose()
    {
        Time.timeScale = 0;
        LosePopup.SetActive(true);
    }


    void Update()
    {
        if (CountdownTimer.currentTime == 0f)
        {
             
            Lose();
        }
    }



    }
