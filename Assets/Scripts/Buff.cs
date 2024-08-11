using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Buff : MonoBehaviour
{

    public float buffHealth = 1;
    public int buffValue = 1;
    public string buffType = "Add";

    private Weapon playerWeaponRef;

    private string[] buffTypes = {"Add","Subtract","Multiply","Divide"};
    // Start is called before the first frame update
    void Start()
    {
        buffType = buffTypes[Random.Range(0,buffTypes.Length-1)];

        gameObject.GetComponentInChildren<TextMeshPro>().text = buffHealth.ToString();

        playerWeaponRef = GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDeath(){

        if(buffType == "Add")
            playerWeaponRef.bulletCount += buffValue;
        else if(buffType == "Subtract")
            playerWeaponRef.bulletCount -= buffValue;
        else if(buffType == "Multiply")
            playerWeaponRef.bulletCount *= buffValue;
        else if(buffType == "Divide")
            playerWeaponRef.bulletCount /= buffValue;

        print(playerWeaponRef.bulletCount);

        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        float damageToTake = col.gameObject.GetComponent<Projectile>().projectileDamage;

        buffHealth -= damageToTake;

        this.gameObject.GetComponentInChildren<TextMeshPro>().text = buffHealth.ToString();

        if(buffHealth == 0)
            OnDeath();
    }
}
