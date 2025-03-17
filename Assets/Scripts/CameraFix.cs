using UnityEngine;

public class CameraFix : MonoBehaviour
{
    void Start()
    {
        
    }
    public GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y,-10f);
    }
}