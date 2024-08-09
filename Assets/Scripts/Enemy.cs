using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float enemySpeed = 1;
    public float enemyHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,0.1f,0) * enemySpeed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float damageToTake = col.gameObject.GetComponent<Projectile>().projectileDamage;

        enemyHealth -= damageToTake;

        this.gameObject.GetComponentInChildren<TextMeshPro>().text = enemyHealth.ToString();
    }
}
