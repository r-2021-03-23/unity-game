using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraChange : MonoBehaviour
{
    public CinemachineVirtualCamera vcam1,vcam2;
    public GameObject player,skill;
    

    // Start is called before the first frame update
    void Start()
    {
        vcam1.Priority = 21;
        vcam2.Priority = 20;
        player.SetActive(true);
        skill.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        iffunction();
    }

    void iffunction()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
             if(rageValue.rageV== 0.1f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",5f);
               
                Invoke("camera1",8f);
            }
            
            if(rageValue.rageV == 0.2f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",7f);
                Invoke("camera1",12f);
            }
            if(rageValue.rageV== 0.3f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",8f);
                Invoke("camera1",14f);
            }
            if(rageValue.rageV == 0.4f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",10f);
                Invoke("camera1",18f);
            }
            if(rageValue.rageV == 0.5f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",12f);
                Invoke("camera1",24f);
            }
            if(rageValue.rageV == 0.6f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",13f);
                Invoke("camera1",26f);
            }
            if(rageValue.rageV == 0.7f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",15f);
                Invoke("camera1",28f);                
            }
            if(rageValue.rageV == 0.8f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",17f);
                Invoke("camera1",30f);                
            }
            if(rageValue.rageV == 0.9f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",19f);
                Invoke("camera1",32f);                
            }
            if(rageValue.rageV == 1.0f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                Invoke("wait",21f);
                Invoke("camera1",35f);
            }
        }
    }

    void wait()
    {
        vcam1.Priority = 21;
        vcam2.Priority = 22;

    }
    void camera1()
    {
        vcam1.Priority = 22;
        vcam2.Priority = 20;        
        player.SetActive(true);
        skill.SetActive(false);
    }
    void camera2()
    {
        vcam1.Priority = 20;
        vcam2.Priority = 22;
    }
}
