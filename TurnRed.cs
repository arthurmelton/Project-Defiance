using person.code;
using UnityEngine;

public class TurnRed : MonoBehaviour
{
    public SpriteRenderer _renderer;

    public int testingOne;

    public int testingTwo;

    // ReSharper disable once MemberCanBePrivate.Global
    public float testingThree;

    private health _health;

    // Start is called before the first frame update
    private void Start()
    {
        _health = gameObject.GetComponent<health>();
        //_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame

    public void _TurnRed()
    {
        var healthFloat = (float) _health.Health / _health.startHealth;

        _renderer.color = new Color(1, healthFloat, healthFloat, 1);
    }
}