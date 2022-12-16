using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    AudioSource audiosource;
    public AudioClip checkpointsound;

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
        if(other.gameObject.CompareTag("checkpoint"))
        {
            Debug.Log(111);
            GetComponent<AudioSource>().clip = checkpointsound;
            GetComponent<AudioSource>().Play();
        }
    }
}
