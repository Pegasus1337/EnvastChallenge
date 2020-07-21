using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox3 : MonoBehaviour
{
   

    public static string BoxPosition;



    void OnTriggerEnter(Collider other)
    {

        CheckBox3.BoxPosition = other.name.ToString();
        // Debug.Log(CheckBox3.BoxPosition);
    }
}
