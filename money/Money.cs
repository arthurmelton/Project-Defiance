using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    public int Dollars;

    // Start is called before the first frame update
    void Start() {

    }

    void Update() {


    }
    void OnTriggerEnter2D( Collider2D collision ) {

        if( collision.gameObject.tag == "Money" ) {

            Dollars++;
            Destroy( collision.gameObject );

        }
    }
}
