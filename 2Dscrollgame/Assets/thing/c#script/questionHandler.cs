using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questionHandler : MonoBehaviour
{
    public static int r;
    public static bool through1,through2,through3;
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
        if(other.gameObject.CompareTag("題目1-1") && through1 == false)
        {
            r = Random.Range (0,1);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through1 = true;
        }
        if(other.gameObject.CompareTag("題目1-2") && through2 == false)
        {
            r = Random.Range (0,1);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through2 = true;
        }


    }  
}
