using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class littleGame_start : MonoBehaviour
{
    // Start is called before the first frame update
    public void cardGameStart()
    {
        SceneManager.LoadScene("level1Card");
    }
    public void MazeGameStart()
    {
        SceneManager.LoadScene("level1Maze");
    }
    public void snakeGameStart()
    {
        SceneManager.LoadScene("level1Snake");
    }
}
