using UnityEngine;
public class SpawnBoss : MonoBehaviour
{
    public GameObject eni1;

    public float bossDmgGetHarderBy;

    public float bossSpeedGetHarderBy;

    public float bossHealthGetHarderBy;

    public void Spawn()
    {
        var transform1 = transform;
        var spawn = Instantiate(eni1, transform1.position, transform1.rotation);
        var spawnEni = spawn.GetComponent<eni.eni>();
        spawnEni.health = (int) (spawnEni.health * bossHealthGetHarderBy);
        spawnEni.MoveSpeed = (int) (spawnEni.MoveSpeed * bossSpeedGetHarderBy);
        spawnEni.ZombieDmg = (int) (spawnEni.ZombieDmg * bossDmgGetHarderBy);
        var scale = spawn.gameObject.transform.localScale;
        spawn.gameObject.transform.localScale = new Vector3(scale.x * 2, scale.y * 2, scale.z * 2);

        //var box = spawn.gameObject.GetComponent<BoxCollider2D>();
        //box.size = new Vector2(box.size.x * 2, box.size.y * 2);
    }
}