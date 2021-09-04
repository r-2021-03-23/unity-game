using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneHis : MonoBehaviour
{
    public static List<string> sceneHistory = new List<string>();
    
    // Start is called before the first frame update
    void Start()
    { 
        DontDestroyOnLoad(this.gameObject);
        Scene scene = SceneManager.GetActiveScene();
        sceneHistory.Add(scene.name);
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    public void changeScene()
    {
        if (sceneHistory.Count >= 2)  
        {
            sceneHistory.RemoveAt(sceneHistory.Count -1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count -1]);
        }
    }
}
