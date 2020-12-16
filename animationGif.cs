using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationGif : MonoBehaviour
{
    public Sprite[] sprites;
    public Image image;
    public float speed;
    public bool destroy;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1 / speed;
        destroy = false;
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = sprites [(int)((Time.time - time)*speed)%sprites.Length];

        if(((int)((Time.time - time) * speed) % sprites.Length) == 12)
        {
            destroy = true;
        }

        if (((int)((Time.time - time) * speed) % sprites.Length) == 0)
        {
            if(destroy == true)
            {
                Destroy(GetComponent<Image>());
                
            }
        }
    }
}
