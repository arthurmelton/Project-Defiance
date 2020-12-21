using person.code;
using TMPro;
using UnityEngine;
public class time : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    public float time1;

    public float nowtime;

    public GameObject player;

    public int round;

    private weapon weapon;

    // Start is called before the first frame update
    private void Start()
    {
        nowtime = Time.time;

        weapon = player.GetComponent<weapon>();
    }

    // Update is called once per frame
    private void Update()
    {
        time1 = Time.time - nowtime;

        time1 = Mathf.Floor(time1);

        tmp.text = "Time : " + time1 + "     Enemies killed : " + weapon.killed + "     Round : " + round;
    }
}