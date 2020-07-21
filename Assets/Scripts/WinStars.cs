using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ; 


public class WinStars : MonoBehaviour
{

    public Image Star1;
    public Image Star2;
    public Image Star3;

    public Sprite YellowStar;
    public Sprite GrayStar; 


    public  void AssignStars(int attempts)
    {
        if ((attempts > 1) && (attempts < 4))
        {
            // Show 2 Stars
            // Show Repeat Button
            Star1.sprite = YellowStar;
            Star2.sprite = YellowStar;
            Star3.sprite = GrayStar; 

        }
        else if ((attempts > 3) && (attempts < 6))
        {
            // Show 1 Stars
            // Show Repeat Button

            Star1.sprite = YellowStar;
            Star2.sprite = GrayStar;
            Star3.sprite = GrayStar;
        }
        else if (attempts > 5)
        {
            // Show 0 Stars
            // Show Repeat Button


            Star1.sprite = GrayStar;
            Star2.sprite = GrayStar;
            Star3.sprite = GrayStar;
        }
    }

}
