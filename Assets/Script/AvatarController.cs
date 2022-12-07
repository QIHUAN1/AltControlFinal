using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{

    public float moveSpeed = 2.5f;

    public Rigidbody2D rb;

    public Animator animator;

    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetTrigger("45");
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("90");
        }
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetTrigger("135");
        }
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetTrigger("180");
        }
        if (Input.GetKey(KeyCode.T))
        {
            animator.SetTrigger("225");
        }
        if (Input.GetKey(KeyCode.Y))
        {
            animator.SetTrigger("270");
        }
        if (Input.GetKey(KeyCode.U))
        {
            animator.SetTrigger("315");
        }
        if (Input.GetKey(KeyCode.I))
        {
            animator.SetTrigger("360");
        }
    }

   

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(firepoint.position.x, firepoint.position.y, 0);
        }

    }
}
