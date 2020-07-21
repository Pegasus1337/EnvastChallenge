using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox2 : MonoBehaviour
{
  

    public static string BoxPosition;



    void OnTriggerEnter(Collider other)
    {

        CheckBox2.BoxPosition = other.name.ToString();
        //Debug.Log(CheckBox2.BoxPosition);
    }
}
