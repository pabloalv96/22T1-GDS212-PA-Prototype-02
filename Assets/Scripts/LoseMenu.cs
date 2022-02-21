using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMenu : MonoBehaviour
{

    public GameObject Loser1;
    public GameObject Loser2;
    public GameObject LoserPanel;

    public AudioClip loseClip;
    public AudioSource audio;

    public bool hasLoseSoundPlayed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Loser1.GetComponent<CarMovement>().impacted || Loser2.GetComponent<CarMovement>().impacted)
        {
            LoserPanel.SetActive(true);
            Time.timeScale = 0f;


            if (!hasLoseSoundPlayed)
            {
                hasLoseSoundPlayed = true;
                audio.PlayOneShot(loseClip);
            }
        }


    }
}
