using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip WallSound;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
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
    }
}
