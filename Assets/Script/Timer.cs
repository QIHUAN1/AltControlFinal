using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float time = 120f;
    [SerializeField] float currentTime;

    AudioSource audiosource;
    public AudioClip clockSound;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();

        audiosource.volume = 0.2f;
        GetComponent<AudioSource>().clip = clockSound;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = time;
        time -= 1 * Time.deltaTime;

        if (currentTime <= 70 && currentTime >= 30)
        {

            audiosource.volume = 0.3f;
        }

        if (currentTime <= 30 && currentTime >= 10)
        {

            audiosource.volume = 0.5f;
        }

        if (currentTime <= 10)
        {

            audiosource.volume = 0.9f;
        }



    }
}
