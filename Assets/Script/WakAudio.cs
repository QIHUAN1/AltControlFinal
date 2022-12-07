using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakAudio : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip walkSound;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<AudioSource>().clip = walkSound;
            GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<AudioSource>().Pause();

        }
    }
}
