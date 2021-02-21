using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;
    
    public Vector3 posDiff;

    public float speed = 1.0f;
    void Start()
    {
        pos1 = transform.position;
        pos2 = transform.position + posDiff;
    }


    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
