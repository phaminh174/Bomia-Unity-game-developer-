using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float Speed;
    public float startPos;
    public float endPos; 
    

    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
        if (transform.position.y <= endPos)
        {
            transform.position = new Vector3(transform.position.x, startPos, transform.position.z);
            
        }
    }
}
