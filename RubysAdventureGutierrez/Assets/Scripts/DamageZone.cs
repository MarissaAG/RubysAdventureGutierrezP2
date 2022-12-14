using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyControlller controller = other.GetComponent<RubyControlller>();

        if (controller !=null)
        {
            controller.ChangeHealth(-1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is alled once per frame
    void Update()
    {
        
    }
}
