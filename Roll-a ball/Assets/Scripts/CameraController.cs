using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    // LateUpdate runs after every Update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // camera position won't set until the player has moved for that frame
        
    }
}
