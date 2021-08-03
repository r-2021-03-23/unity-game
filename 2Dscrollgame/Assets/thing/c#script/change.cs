using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject cam1,cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(enemy.rageV >= 0.1f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
        }
    }
}
