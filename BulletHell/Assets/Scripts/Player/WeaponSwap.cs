using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    float firerate = 0.5f;
    float canfire = 0.5f;
    bool ranged = true;
    [SerializeField] private GameObject Ranged;
    [SerializeField] private GameObject Melee;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && Time.time > canfire)
        {

            if (ranged)
            {
                Ranged.SetActive(false);
                Melee.SetActive(true);
                ranged = false;
            }
            else
            {
                Ranged.SetActive(true);
                Melee.SetActive(false);
                ranged = true;
            }
            canfire = Time.time + firerate;
        }
    }
}
