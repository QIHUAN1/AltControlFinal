using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvatarController : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator animator;

    public Transform firepoint;

    AudioSource audiosource;
    public AudioClip RotateSound;
    public AudioClip RotateSound2;


    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("45");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("90");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("135");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("180");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetTrigger("225");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.G))
        {
            animator.SetTrigger("270");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetTrigger("315");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetTrigger("360");
            GetComponent<AudioSource>().clip = RotateSound2;
            GetComponent<AudioSource>().Play();
        }
    }

   

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(firepoint.position.x, firepoint.position.y, 0);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
