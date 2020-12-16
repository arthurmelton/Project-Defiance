using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberofeni : MonoBehaviour
{
    public TextMesh tm;

    public int numberofeni1;

    // Start is called before the first frame update
    void Start()
    {
        numberofeni1 -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        

        tm.text = numberofeni1.ToString();
    }
}
