using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    AudioSource audiosource;
    public AudioClip DoorSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            GetComponent<AudioSource>().clip = DoorSound;
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
    }
}
