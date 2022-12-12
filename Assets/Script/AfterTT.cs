using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AfterTT : MonoBehaviour
{

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


        if(readytime >= 132)
        {
            readytime = 132;
        }

        if (readytime == 132 && heather == true)
        {
            if (Input.GetMouseButtonDown(0))
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
        SceneManager.LoadScene(3);
    }
}
