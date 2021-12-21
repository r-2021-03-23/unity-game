using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
public class cameraChange : MonoBehaviour
{
    public CinemachineVirtualCamera vcam1,vcam2;
    public GameObject player,skill,time_left,time_left_back;
    
    public Image time_left_img;
    public float timecount,timeset;
    // Start is called before the first frame update
    void Start()
    {
        vcam1.Priority = 21;
        vcam2.Priority = 20;
        player.SetActive(true);
        skill.SetActive(false);
        time_left_back.SetActive(false);
        time_left.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        timecount -= Time.deltaTime;
        time_left_img.fillAmount =  1 - ((timeset - timecount) / timeset);
        if(Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.Joystick1Button4))
        {
             if(rageValue.rageV== 0.1f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",5f);
                Invoke("camera1",8f);                
                timecount = 8f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;
                
            }
            
            if(rageValue.rageV == 0.2f)
            {


                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",7f);
                Invoke("camera1",12f);                
                timecount = 12f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;
            }
            if(rageValue.rageV== 0.3f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",8f);
                Invoke("camera1",14f);                
                timecount = 14f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;

            }
            if(rageValue.rageV == 0.4f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",10f);
                Invoke("camera1",18f);                
                timecount = 18f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;

            }
            if(rageValue.rageV == 0.5f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",12f);
                Invoke("camera1",24f);               
                timecount = 24f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;
            }
            if(rageValue.rageV == 0.6f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",13f);
                Invoke("camera1",26f);                
                timecount = 26f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;
            }
            if(rageValue.rageV == 0.7f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",15f);
                Invoke("camera1",28f);                   
                timecount = 28f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;             
            }
            if(rageValue.rageV == 0.8f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",17f);
                Invoke("camera1",30f);                
                timecount = 30f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;                
            }
            if(rageValue.rageV == 0.9f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",19f);
                Invoke("camera1",32f);                
                timecount = 32f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;                
            }
            if(rageValue.rageV == 1.0f)
            {

                player.SetActive(false);
                skill.SetActive(true);
                camera2();
                Invoke("wait",21f);
                Invoke("camera1",35f);                
                timecount = 35f;
                timeset = timecount;
                timecount = timecount - Time.deltaTime;
            }
        }
        if(vcam2.Priority > vcam1.Priority)
        {
            time_left_back.SetActive(true);
            time_left.SetActive(true);
        }
        else
        {
            time_left_back.SetActive(false);
            time_left.SetActive(false);
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
