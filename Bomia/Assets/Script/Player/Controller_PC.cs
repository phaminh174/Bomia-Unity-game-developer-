using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_PC : MonoBehaviour
{
    public float maxHeight;
    public float minHeight;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + distance);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - distance);
            }
        }
    }
}
