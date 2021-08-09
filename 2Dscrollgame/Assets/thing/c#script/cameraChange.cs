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
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);
            }
            if(rageValue.rageV== 0.3f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);
            }
            if(rageValue.rageV == 0.4f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);
            }
            if(rageValue.rageV == 0.5f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);
            }
            if(rageValue.rageV == 0.6f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);
            }
            if(rageValue.rageV == 0.7f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);                
            }
            if(rageValue.rageV == 0.8f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);                
            }
            if(rageValue.rageV == 0.9f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);
                player.SetActive(true);
                skill.SetActive(false);
                Invoke("camera1",3f);                
            }
            if(rageValue.rageV == 1.0f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("camera2",2f);

                
                Invoke("camera1",3f);
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
