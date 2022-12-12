using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip WallSound;
    public AudioClip PlayerSound;

    public GameObject audioSound;


    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audioSound = GameObject.FindGameObjectWithTag("Audio");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            GetComponent<AudioSource>().clip = WallSound;
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().GetComponent<AudioSource>().clip = PlayerSound;
            GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            GetComponent<AudioSource>().GetComponent<AudioSource>().Pause();
        }
    }
}
