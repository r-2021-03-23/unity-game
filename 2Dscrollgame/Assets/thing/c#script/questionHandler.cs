using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questionHandler : MonoBehaviour
{
    public static int r,x;
    public static bool[] through = {false,false,false};
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
        if(other.gameObject.CompareTag("題目1-1") && through[0] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[0] = true;
            x = 0;
        }
        if(other.gameObject.CompareTag("題目1-2") && through[1] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[1] = true;
            x = 1;
        }


    }  
}
