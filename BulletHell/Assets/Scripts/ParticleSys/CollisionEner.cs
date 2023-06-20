using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEner : MonoBehaviour
{      
    void OnParticleCollision(GameObject other)
    {
        Debug.Log(123);
        PlayerHP player = other.GetComponent<PlayerHP>();
        if (player != null)
        {
            player.TakeDamage(1);
        }
        
    }
}
