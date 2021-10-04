using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuestionThrough : MonoBehaviour
{
    public static bool[] through = {false,false,false,false,false,false,false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
    public static int r,y;
    
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("題目-1") && through[0] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[0] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目-2") && through[1] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[1] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目2-1") && through[2] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[2] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目2-2") && through[3] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[3] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目3-1") && through[4] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[4] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目3-2") && through[5] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[5] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目4-1") && through[6] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[6] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目4-2") && through[7] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[7] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目4-3") && through[8] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[8] = true;
            y = 2;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目5-1") && through[9] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[9] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目5-2") && through[10] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[10] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目5-3") && through[11] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[11] = true;
            y = 2;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目6-1") && through[12] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[12] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目6-2") && through[13] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[13] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目6-3") && through[14] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[14] = true;
            y = 2;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目7-1") && through[15] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[15] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目7-2") && through[16] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[16] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目7-3") && through[17] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[17] = true;
            y = 2;
            player.CanPlay = false;
        }       
        if(other.gameObject.CompareTag("題目8-1") && through[18] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[18] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目8-2") && through[19] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[19] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目8-3") && through[20] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[20] = true;
            y = 2;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目9-1") && through[21] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[21] = true;
            y = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目9-2") && through[22] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[22] = true;
            y = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目9-3") && through[23] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[23] = true;
            y = 2;
            player.CanPlay = false;
        }  
    }


}
