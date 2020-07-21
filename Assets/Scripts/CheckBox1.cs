using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox1 : MonoBehaviour
{
  

    public static string BoxPosition;



    void OnTriggerEnter(Collider other)
    {

        CheckBox1.BoxPosition = other.name.ToString();
        //Debug.Log(CheckBox1.BoxPosition);
    }
}
