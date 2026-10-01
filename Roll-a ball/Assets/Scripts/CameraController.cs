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
    // LateUpdate is called after all Update functions have been completed.
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
            // camera position won't set until the player has moved for that frame
            
        }
        
    }
}
