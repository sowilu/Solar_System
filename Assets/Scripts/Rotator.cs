using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public - exposed in inspector
    public float speed = 100;
    
    void Update()
    {
        //speed per second not speed per frame
        transform.Rotate(0, speed * Time.deltaTime,0);
    }
}
