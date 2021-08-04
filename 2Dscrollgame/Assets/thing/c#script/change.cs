using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject cam1,cam2;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(enemy.rageV == 0.1f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",2f);
            }
            if(enemy.rageV == 0.2f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",3f);
            }
             if(enemy.rageV == 0.3f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",5f);
            } 
            if(enemy.rageV == 0.4f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",7f); 
            } 
            if(enemy.rageV == 0.5f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",9f);
            } 
            if(enemy.rageV == 0.6f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",11f);
            } 
            if(enemy.rageV == 0.7f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",13f);
            } 
            if(enemy.rageV == 0.8f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",15f);
            } 
            if(enemy.rageV == 0.9f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",17f);
            } 
            if(enemy.rageV == 1f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                Invoke("camera1",19f);
            } 
        }
    }

    void camera1()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }
}
