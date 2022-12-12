using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public int Scene;

    AudioSource audiosource;
    public AudioClip ready;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (Input.GetMouseButtonDown(0))
            {

                GetComponent<AudioSource>().clip = ready;
                GetComponent<AudioSource>().Play();

                Invoke("NextScene", 10f);
            }
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
