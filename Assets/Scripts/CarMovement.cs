using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float speed = 5f;
    public float initialSpeed = 5f;
    public bool impacted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);

        if (gameObject.tag == "Car1")
        {
            if(Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            } else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        } else if (gameObject.tag == "Car2")
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            } else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //Time.timeScale = 0f;
            impacted = true;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Fence")
        {
            speed = 1f;
        }
    } 
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Fence")
        {
            Debug.Log("Border reached");
            speed = initialSpeed;
        }
    }
}
