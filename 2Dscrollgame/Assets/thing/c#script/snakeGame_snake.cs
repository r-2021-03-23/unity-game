using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class snakeGame_snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _segements = new List<Transform>();

    public static int s = 0;
    public Transform segementPrefab;

    public Text Text;

    public GameObject button;
    private void Start()
    {
        button.SetActive(false);
        ResetState();
        Time.timeScale = 0.06f;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }

        if(_segements.Count == 16)
        {
            Text.text = "You Win!";
            button.SetActive(true);
            Time.timeScale = 0;
            s=1;
        }

    }

    private void FixedUpdate()
    {
        for(int i = _segements.Count-1;i>0;i--)
        {
            _segements[i].position = _segements[i-1].position;
        }
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x)+_direction.x,
            Mathf.Round(this.transform.position.y )+ _direction.y,
            0.0f
            );
    }



    private void Grow()
    {
        Transform segement = Instantiate(this.segementPrefab);
        segement.position = _segements[_segements.Count - 1].position;
                                             
        _segements.Add(segement);
    }

    private void ResetState()
    {
        for(int i =1 ;i<_segements.Count;i++)
        {
            Destroy(_segements[i].gameObject);
        }

        _segements.Clear();
        _segements.Add(this.transform);

        this.transform.position = Vector3.zero;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("food") )
        {
            Grow();
        }
        if(other.gameObject.CompareTag("obstacle"))
        {
            ResetState();
        }
    }
    public void Button()
    {
        SceneManager.LoadScene("UILevel");
    }
}
