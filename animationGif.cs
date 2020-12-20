using UnityEngine;
using UnityEngine.UI;

public class animationGif : MonoBehaviour
{
    public Sprite[] sprites;
    public Image image;
    public float speed;
    public bool destroy;

    private Image _image;
    private float _time;

    // Start is called before the first frame update
    private void Start()
    {
        _image = GetComponent<Image>();
        speed = 1 / speed;
        destroy = false;
        _time = Time.time;
    }

    // Update is called once per frame
    private void Update()
    {
        image.sprite = sprites[(int) ((Time.time - _time) * speed) % sprites.Length];

        if ((int) ((Time.time - _time) * speed) % sprites.Length == 12) destroy = true;

        if ((int) ((Time.time - _time) * speed) % sprites.Length != 0) return;
        if (destroy) Destroy(_image);
    }
}