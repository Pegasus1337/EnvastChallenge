using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityLineRendererTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go1;
    public GameObject go2;


    LineRenderer l;

    void Start()
    {
        l = gameObject.AddComponent<LineRenderer>();
        l.startColor = Color.red;
        l.endColor = Color.red;

    }



    // Update is called once per frame
    void Update()
    {
        List<Vector3> pos = new List<Vector3>();
        pos.Add(go1.transform.position);
        pos.Add(go2.transform.position);
        l.startWidth = 15f;
        l.endWidth = 15f;
        l.SetPositions(pos.ToArray());
        l.useWorldSpace = true;

 


    }
}