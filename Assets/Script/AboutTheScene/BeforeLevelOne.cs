using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BeforeLevelOne : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip ready;

    public float readytime;

    public bool heather;


    // Start is called before the first frame update
    void Start()
    {
        heather = true;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        readytime += 1 * Time.deltaTime;

        if (readytime >= 11)
        {
            readytime = 11;
        }

        if(readytime == 11)
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
