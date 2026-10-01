using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float amplitude = 0.5f;
    public float frequency = 3f;
    private Vector3 startPos;


    void Start() 
    { 
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        float y = Mathf.Sin(Time.time * frequency * 2f * Mathf.PI) * amplitude;
        transform.position = startPos + Vector3.up * y;
        
    }
}
