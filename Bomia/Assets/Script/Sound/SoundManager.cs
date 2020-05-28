using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip lightningSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        lightningSound = Resources.Load<AudioClip>("lightning");
        audioSrc = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Time.timeScale == 0)
        {
            audioSrc.Pause();
        } else audioSrc.UnPause();
    }
    // Update is called once per frame
    public static void PlaySound (string clip)
    {
        if (clip == "lightning") audioSrc.PlayOneShot(lightningSound);
    }
}
