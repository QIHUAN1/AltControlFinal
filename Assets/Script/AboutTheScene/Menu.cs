using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);

        }
    }
}
