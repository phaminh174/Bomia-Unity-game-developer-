using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObtacles : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }
}
