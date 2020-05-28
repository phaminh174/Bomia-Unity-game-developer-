using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingEffect : MonoBehaviour
{
    public Animator anim;
    private float time = 0f;
    public float timeLighting;
    public float minTime, maxTime;
    // Start is called before the first frame update
    void Start()
    {
        timeLighting = Random.Range(minTime, maxTime);
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeLighting) 
        {
            timeLighting = Random.Range(minTime, maxTime);
            time = 0;
            anim.SetTrigger("lighting");
            SoundManager.PlaySound("lightning");
        }
    }
}
