using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float time = 200f;
    [SerializeField] float currentTime;

    public int Scene;

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

        if (currentTime <= 120 && currentTime >= 60)
        {

            audiosource.volume = 0.3f;
        }

        if (currentTime <= 60 && currentTime >= 10)
        {

            audiosource.volume = 0.5f;
        }

        if (currentTime <= 10)
        {

            audiosource.volume = 0.9f;
        }


        if (time <= 0)
        {
            time = 0;
        }



        if (time == 0)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
