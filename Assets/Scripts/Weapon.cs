using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject weapon;
    public GameObject bullet;
    public float weaponCooldown = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet",1.0f,weaponCooldown);

        print("x" + weapon.GetComponent<SpriteRenderer>().bounds.max.x);
        print("y" + weapon.GetComponent<SpriteRenderer>().bounds.max.y);
    }

    // Update is called once per frame
    void Update()
    {
        print(weapon.GetComponent<SpriteRenderer>().bounds.max);

        
    }

    private void SpawnBullet(){

        float center = weapon.GetComponent<SpriteRenderer>().bounds.min.x + ((weapon.GetComponent<SpriteRenderer>().bounds.max.x - weapon.GetComponent<SpriteRenderer>().bounds.min.x) / 2);



        Vector3 bulletSpawnLoc = new Vector3(center,
        weapon.GetComponent<SpriteRenderer>().bounds.max.y,
        0);

        Instantiate(bullet,bulletSpawnLoc, new Quaternion(0,0,0,0));
    }
}
