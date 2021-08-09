using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rageValue : MonoBehaviour
{
    public Image rageValues,release;

    public static float rageV;

    public GameObject gameOver;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rageV = rageValues.fillAmount;
        if(release.fillAmount > rageValues.fillAmount)
        {
            release.fillAmount -= 0.01f;
        }
        else
        {
            release.fillAmount = rageValues.fillAmount;
        }
        if(gameOver.activeSelf == true)
        {
            rageValues.fillAmount = 0f;
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            
            if(rageV >= 0.1f)
            {
                rageValues.fillAmount = 0f;
            }
            
            
        }
    }
}
