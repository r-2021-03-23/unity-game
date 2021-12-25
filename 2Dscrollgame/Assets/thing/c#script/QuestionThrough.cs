using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.LowLevel;
public class QuestionThrough : MonoBehaviour
{
    public static bool[] through = {false,false,false,false,false,false,false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
    public static int r,y,x;
    
    
    public Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isGameOver == true)
        {
            for(int i = 0;i<through.Length;i++)
            {
                through[i] = false;
            }
        }
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("題目-1") && through[0] == false)
        {
            r = Random.Range (0,30);
            
            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[0] = true;
            y = 0;
            x = 0;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目-2") && through[1] == false)
        {
            r = Random.Range (0,30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[1] = true;
            y = 1;
            x = 1;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目2-1") && through[2] == false)
        {
            r = Random.Range (0,30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[2] = true;
            y = 0;
            x = 2;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目2-2") && through[3] == false)
        {
            r = Random.Range (0,30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[3] = true;
            y = 1;
            x = 3;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目3-1") && through[4] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[4] = true;
            y = 0;
            x = 4;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目3-2") && through[5] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[5] = true;
            y = 1;
            x = 5;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目4-1") && through[6] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[6] = true;
            y = 0;
            x = 6;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目4-2") && through[7] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[7] = true;
            y = 1;
            x = 7;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目4-3") && through[8] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[8] = true;
            y = 2;
            x = 8;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目5-1") && through[9] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[9] = true;
            y = 0;
            x = 9;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目5-2") && through[10] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[10] = true;
            y = 1;
            x = 10;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目5-3") && through[11] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[11] = true;
            y = 2;
            x = 11;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目6-1") && through[12] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[12] = true;
            y = 0;
            x = 12;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目6-2") && through[13] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[13] = true;
            y = 1;
            x = 13;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目6-3") && through[14] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[14] = true;
            y = 2;
            x = 14;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目7-1") && through[15] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[15] = true;
            y = 0;
            x = 15;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目7-2") && through[16] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[16] = true;
            y = 1;
            x = 16;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目7-3") && through[17] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[17] = true;
            y = 2;
            x = 17;
            player.CanPlay = false;
        }       
        if(other.gameObject.CompareTag("題目8-1") && through[18] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[18] = true;
            y = 0;
            x = 18;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目8-2") && through[19] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[19] = true;
            y = 1;
            x = 19;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目8-3") && through[20] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[20] = true;
            y = 2;
            x = 20;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目9-1") && through[21] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[21] = true;
            y = 0;
            x = 21;
            player.CanPlay = false;
        }

        if(other.gameObject.CompareTag("題目9-2") && through[22] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[22] = true;
            y = 1;
            x = 22;
            player.CanPlay = false;
        }
        if(other.gameObject.CompareTag("題目9-3") && through[23] == false)
        {
            r = Random.Range(0, 30);

            SceneManager.LoadSceneAsync(r+11,LoadSceneMode.Additive);
            through[23] = true;
            y = 2;
            x = 23;
            player.CanPlay = false;
        }  
    }
    
    void IS()
    {
        if(player.isGameOver == true)
        {
            for(int i = 0;i<through.Length;i++)
            {
                through[i] = false;
            }
        }
    }
}
