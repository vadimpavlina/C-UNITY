using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickRunJumpGame()
    {
        SceneManager.LoadScene("JumpScene");
    }

    public void OnClickGoGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickExitGame()
    {
        Application.Quit();
    }
}
