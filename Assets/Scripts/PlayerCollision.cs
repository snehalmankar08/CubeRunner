using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name=="Red Cube")
        {
            Destroy(other.gameObject);

        }
    }
    
}
