using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DestroyAfter : MonoBehaviour
{
    [FormerlySerializedAs("Time")] public float time;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        Destroy(gameObject, time);
    }
}
