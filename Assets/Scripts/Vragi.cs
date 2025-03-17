using UnityEngine;

public class Vragi : MonoBehaviour
{
    public float speed = 0f;
    public float stoppingDistance = 1f;

    void Start()
    {

    }
    public PlayerControl player;

    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currHealth -= 10f;
        Destroy(gameObject);
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x-1, player.transform.position.y);
    }
}