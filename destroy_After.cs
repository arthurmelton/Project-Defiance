using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_After : MonoBehaviour
{
    public float Time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, Time);
    }
}
