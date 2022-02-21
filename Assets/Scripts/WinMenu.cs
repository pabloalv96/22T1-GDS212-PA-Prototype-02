using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public GameObject winner;
    public GameObject winnerPanel;

    public AudioClip winClip1;
    public AudioClip winClip2;
    public AudioSource audio;

    public bool hasWinSoundPlayed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (winner.GetComponent<FinalLine>().winner)
        {
            winnerPanel.SetActive(true);
            Time.timeScale = 0f;


            if (!hasWinSoundPlayed)
            {
                hasWinSoundPlayed = true;
                audio.PlayOneShot(winClip1);
                audio.PlayOneShot(winClip2);
            }
        }


    }
}
