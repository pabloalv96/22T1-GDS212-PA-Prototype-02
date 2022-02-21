using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float obstacleSpeed = 20f;
    //private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0f, 0f, -obstacleSpeed * Time.deltaTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -obstacleSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Shredder")
        {
           Destroy(gameObject);
        }
       
    }
}
