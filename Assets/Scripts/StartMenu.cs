using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public bool gameStart = false;


    public GameObject startPanel;
    public GameObject InstructionsPanel;
    public GameObject WinPanel;

    // Start is called before the first frame update
    void Start()
    {
        
        if (!gameStart)
        {
            Time.timeScale = 0f;
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        startPanel.SetActive(false);
        InstructionsPanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        startPanel.SetActive(false);
        gameStart = true;

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
