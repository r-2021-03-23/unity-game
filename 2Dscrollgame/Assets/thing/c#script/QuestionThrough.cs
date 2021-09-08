using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuestionThrough : MonoBehaviour
{
    public Vector2[] dir;
    public bool[] through = {false,false};
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
            rb.MovePosition(dir[0]);
        }

        if(other.gameObject.CompareTag("題目-2") && through[1] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[1] = true;
            y = 1;
            rb.MovePosition(dir[1]);
        }
        if(other.gameObject.CompareTag("題目-3") && through[2] == false)
        {
            r = Random.Range (0,25);

            SceneManager.LoadScene(r+11,LoadSceneMode.Additive);
            through[2] = true;
            y = 1;
            rb.MovePosition(dir[2]);
        }
    }
}
