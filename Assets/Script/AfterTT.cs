using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AfterTT : MonoBehaviour
{

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
        Invoke("Nextscene1", 132 * Time.deltaTime);
    }

    void Nextscene1()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().clip = ready;
            GetComponent<AudioSource>().Play();

            Invoke("NextScene", 10f);
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(3);
    }
}
