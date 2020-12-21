using UnityEngine;

public class GetHarder : MonoBehaviour
{
    // ReSharper disable once MemberCanBePrivate.Global
    public time time1;

    public float healthGetHarderBy;

    public float speedGetHarderBy;

    public float dmgGetHarderBy;

    private eni.eni _eni;

    // Start is called before the first frame update
    private void Start()
    {
        _eni = gameObject.GetComponent<eni.eni>();

        var round = time1.round;

        if (round == 0 || round == 1) return;
        _eni.health = (int) (_eni.health * Mathf.Pow(healthGetHarderBy + 1, round));

        _eni.MoveSpeed *= Mathf.Pow(speedGetHarderBy + 1, round);

        _eni.ZombieDmg = (int) (_eni.ZombieDmg * Mathf.Pow(dmgGetHarderBy + 1, round));
    }
}