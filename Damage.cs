using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public NewBehaviourScript pHealth;
    public float damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other )
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pHealth.health -= damage;
        }
       
    }
}
