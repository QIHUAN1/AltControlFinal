using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public int Scene;

    AudioSource audiosource;
    public AudioClip ready;

    public float readytime;

    public bool heather;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        heather = true;
    }

    // Update is called once per frame
    void Update()
    {
        readytime += 1 * Time.deltaTime;

        if (readytime >= 14)
        {
            readytime = 14;
        }

        if(readytime == 14)
        {
            if (Input.GetMouseButtonDown(0) && heather == true)
            {

                GetComponent<AudioSource>().clip = ready;
                GetComponent<AudioSource>().Play();

                Invoke("NextScene", 10f);
                heather = false;

            }
        }

     
    }

    void NextScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
