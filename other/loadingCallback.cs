using UnityEngine;

namespace other
{
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
}
