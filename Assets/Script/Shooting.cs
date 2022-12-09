using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletp;


    AudioSource audiosource;
    public AudioClip shootsound;

    public float bulletForce = 2f;


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
            
            GameObject bullet = Instantiate(bulletp, firepoint.position, firepoint.rotation);
            GetComponent<AudioSource>().clip = shootsound;
            GetComponent<AudioSource>().Play();
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
