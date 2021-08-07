using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject cam1,cam2;
    public GameObject player;
    public GameObject skill;
    
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        skill.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(enemy.rageV == 0.1f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
                
                Invoke("camera1",2f);
            }
            if(enemy.rageV == 0.2f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
                
                Invoke("camera1",3f);
            }
             if(enemy.rageV == 0.3f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
                
                Invoke("camera1",5f);
            } 
            if(enemy.rageV == 0.4f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
               
                Invoke("camera1",7f); 
            } 
            if(enemy.rageV == 0.5f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
                
                Invoke("camera1",9f);
            } 
            if(enemy.rageV == 0.6f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
                
                Invoke("camera1",11f);
            } 
            if(enemy.rageV == 0.7f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
                
                Invoke("camera1",13f);
            } 
            if(enemy.rageV == 0.8f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
    
                Invoke("camera1",15f);
            } 
            if(enemy.rageV == 0.9f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);
 
                Invoke("camera1",17f);
            } 
            if(enemy.rageV == 1f)
            {
                player.SetActive(false);
                skill.SetActive(true);
                Invoke("wait",2f);

                Invoke("camera1",19f);
            } 
        }
    }

    void camera1()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        player.SetActive(true);
        skill.SetActive(false);
    }

    void wait()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
}
