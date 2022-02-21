using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLine : MonoBehaviour
{
    public bool winner = false;
 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car1" || other.gameObject.tag == "Car2")
        {
            //Time.timeScale = 0f;
            winner = true;
        }
        
    }

}
