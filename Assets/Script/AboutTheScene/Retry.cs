using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public int Scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene(Scene);
        }

        if (Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene(0);

        }
    }
}