using UnityEngine;

public class Health : MonoBehaviour
{
    public PlayerControl player;

    void Start()
    {

    }

    void Update()
    {
        float healthPercent = (player.currHealth / player.maxHealth) * 1;
        float healthLevel = healthPercent / 6;
        transform.localScale = new Vector3(healthLevel, 0.2f, 1f);
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1f, transform.position.z);
    }
}