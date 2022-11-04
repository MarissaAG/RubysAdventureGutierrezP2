using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyControlller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Create 2 variables to use the unity built in axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Create our movement vector
        Vector2 position = transform.position;

        //Create horizontal and vertical movement
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        //Setting new position
        transform.position = position;
    }
}
