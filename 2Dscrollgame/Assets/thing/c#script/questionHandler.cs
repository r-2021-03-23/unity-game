using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questionHandler : MonoBehaviour
{
    int r;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("題目"))
        {
            r = Random.Range (0,5);
            SceneManager.LoadScene(r+13);
        }


    }  
}
