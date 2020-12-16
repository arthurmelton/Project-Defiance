using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingCallback : MonoBehaviour
{
    private bool IsFirstUpdate = true;

    private void Update()
    {
        if (IsFirstUpdate)
        {
            IsFirstUpdate = false;
            loader.LoaderCallback();
        }
    }
}
