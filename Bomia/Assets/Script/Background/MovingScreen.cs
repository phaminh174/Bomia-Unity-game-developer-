using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScreen : MonoBehaviour
{
    public float Speed;
    public float endPos, startPos;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
        if (transform.position.x <= endPos)
        {
            pos = new Vector3(startPos, transform.position.y, transform.position.z);
            transform.position = pos;
        }
    }
}
