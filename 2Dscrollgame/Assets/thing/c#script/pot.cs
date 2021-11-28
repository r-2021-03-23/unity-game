using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pot : MonoBehaviour
{
    float x;
    public GameObject potPrefab;
    // Start is called before the first frame update
    void Start()
    {
        x = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.hp <= 0)
        {
            if(x == 0f) 
            {
                Instantiate(potPrefab,this.transform.position+new Vector3(0,0,0),Quaternion.identity);
                x = 1f;
            }
        }
        
    }
}
