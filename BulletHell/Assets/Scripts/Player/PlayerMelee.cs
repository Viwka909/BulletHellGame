using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
     public Animator Swipe;
    public int swrddmg = 10;
    float firerate = 0.5f;
    float canfire = 0.5f;
    public Collider2D hitbox;
    public GameObject Swrod;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > canfire)
        {
            
            Swing();
            canfire = Time.time + firerate;
        }

        void Swing()
        {
            Swrod.SetActive(true);
            Swipe.SetTrigger("Swing");
        }
        
    }
     void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null){
            enemy.TakeDamage(swrddmg);
        }
        
    }
}
