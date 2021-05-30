using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeGame_food : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider2D gridArea;

    private void Start()
    {
        RamdomizePosition();
    }
    private void RamdomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x,bounds.max.x);
        float y = Random.Range(bounds.min.y,bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x),Mathf.Round(y),0.0f);
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") )
        {
            RamdomizePosition();
        }
    }    
}
