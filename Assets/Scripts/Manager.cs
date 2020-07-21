using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Manager : MonoBehaviour
{
    public static int attempts = 0; // Number of Attempts 
    public static int score = 0;
    public static int RoundNumber  ;


    public Sprite[] Images; // Array Containing all the 49 Sprite Images
    public string[] ElementsNames; // Array Containing the 49 names of the Sprite Images in order 

    public Sprite[] DisplayedElementsImages ; // Array Containing 3 Sprites Randomly taken from the Images Array
    public static string[] DisplayedElementsNames = { "placeholder","placeholder","placeholder"} ; // Array Containing the respective 3 names of the taken Sprite Images 

    public static string[] ShuffeledNames = { "placeholder", "placeholder", "placeholder" }; // Array Containing the names of the Displayed Images but not in order ( we applied a shuffle algorithme ) 

    public SpriteRenderer Sprite1;
    public SpriteRenderer Sprite2;
    public SpriteRenderer Sprite3;

    public TextMeshProUGUI txt1;
    public TextMeshProUGUI txt2;
    public TextMeshProUGUI txt3;




    // Start Function 
    void Start()
    {
        

        Display();
        
    }




    // Other Functions 


    void Shuffle(string[] array) // Shuffles The Elements of the Names Table 
    {
       
    int p = array.Length;

        for (int n = p - 1; n > 0; n--)
        {
            int r = Random.Range(1, n);
            string t = array[r];
            array[r] = array[n];
            array[n] = t;
        }
    }


    void Display()
    {
        for (int i = 0; i< 3; i++)
        {

            int rand = Random.Range(0, Images.Length);
            DisplayedElementsImages[i] = Images[rand];
            Manager.DisplayedElementsNames[i] = ElementsNames[rand];

        }

        for (int j = 0; j < 3; j++)
        {
            Manager.ShuffeledNames[j] = Manager.DisplayedElementsNames[j];
        }

        Shuffle(Manager.ShuffeledNames);

        Sprite1.sprite = DisplayedElementsImages[0];
        Sprite2.sprite = DisplayedElementsImages[1];
        Sprite3.sprite = DisplayedElementsImages[2];
        txt1.SetText(Manager.ShuffeledNames[0]);
        txt2.SetText(Manager.ShuffeledNames[1]);
        txt3.SetText(Manager.ShuffeledNames[2]);

        // now we need to assign Labels to Array Content 
    }

    

    public static void AssignStarsNdScore(int attempts)
    {

      
        if ( attempts == 1)
        {
            // Show 3 Stars 
            // No Repeat Button

            Manager.score += 100;

        }else if ((attempts > 1) && (attempts < 4))
        {
            // Show 2 Stars
            // Show Repeat Button






            Manager.score += 60;
            
        }
        else if ((attempts > 3) && (attempts < 6))
        {
            // Show 1 Stars
            // Show Repeat Button
           


            Manager.score += 30;
        }
        else if (attempts > 5)
        {
            // Show 0 Stars
            // Show Repeat Button

            



            Manager.score += 10;
        }
        

    }



}
