using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyControlller controller = other.GetComponent<RubyControlller>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}

       
    
    // Start is called before the first frame update
   
    // Update is called once per frame
  

