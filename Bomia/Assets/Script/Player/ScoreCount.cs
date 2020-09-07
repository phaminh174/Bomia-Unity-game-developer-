using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public PlayGroundCanvas PlayGround;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pipe"))
        {
            PlayGround.AddScore();
        }
    }
}
