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

    public bool a45;
    public bool a90;
    public bool a135;
    public bool a180;
    public bool a225;
    public bool a270;
    public bool a315;
    public bool a360;





    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();

        a360 = true;

        a45 = false;
        a90 = false;
        a135 = false;
        a180= false;
        a225= false;
        a270= false;
        a315= false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && a45 == false)
        {
            animator.SetTrigger("45");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a45 = true;

            a90 = false;
            a135 = false;
            a180 = false;
            a225 = false;
            a270 = false;
            a315 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.A) && a90 == false)
        {
            animator.SetTrigger("90");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a90 = true;

            a45 = false;
            a135 = false;
            a180 = false;
            a225 = false;
            a270 = false;
            a315 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.S)&& a135 == false)
        {
            animator.SetTrigger("135");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a135 = true;

            a90 = false;
            a45 = false;
            a180 = false;
            a225 = false;
            a270 = false;
            a315 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.D) && a180 == false)
        {
            animator.SetTrigger("180");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a180 = true;

            a135 = false;
            a90 = false;
            a45 = false;
            a225 = false;
            a270 = false;
            a315 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.F) && a225 == false)
        {
            animator.SetTrigger("225");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a225 = true;

            a180 = false;
            a135 = false;
            a90 = false;
            a45 = false;
            a270 = false;
            a315 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.G) && a270 == false)
        {
            animator.SetTrigger("270");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a270 = true;

            a225 = false;
            a180 = false;
            a135 = false;
            a90 = false;
            a45 = false;
            a315 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.UpArrow) && a315 == false)
        {
            animator.SetTrigger("315");
            GetComponent<AudioSource>().clip = RotateSound;
            GetComponent<AudioSource>().Play();

            a315 = true;

            a270 = false;
            a225 = false;
            a180 = false;
            a135 = false;
            a90 = false;
            a45 = false;
            a360 = false;
        }
        if (Input.GetKey(KeyCode.DownArrow)&& a360 == false)
        {
            animator.SetTrigger("360");
            GetComponent<AudioSource>().clip = RotateSound2;
            GetComponent<AudioSource>().Play();

            a360 = true;
            a315 = false;
            a270 = false;
            a225 = false;
            a180 = false;
            a135 = false;
            a90 = false;
            a45 = false;

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
