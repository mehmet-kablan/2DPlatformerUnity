using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject weapon;
    public GameObject bullet;
    public float weaponCooldown = 1;
    public int bulletCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet",1.0f,weaponCooldown);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBullet(){

        float totalDistance = weapon.GetComponent<SpriteRenderer>().bounds.max.x - weapon.GetComponent<SpriteRenderer>().bounds.min.x;
        float bulletDistance = totalDistance / ((bulletCount > 5 ? 5 : bulletCount) + 1);
        float firstBulletLocX = weapon.GetComponent<SpriteRenderer>().bounds.min.x + bulletDistance;
        

        //if(bulletCount <= 5){
            for(int i = 0; i < bulletCount; i++){

                if(i<5){
                Vector3 firstBulletSpawnLoc = new Vector3(firstBulletLocX + (i * bulletDistance),
                weapon.GetComponent<SpriteRenderer>().bounds.max.y,
                0);
                
                Instantiate(bullet, firstBulletSpawnLoc, new Quaternion(0,0,0,0));
                }
            }
        //}
        if(bulletCount > 5){

            bulletDistance = totalDistance / (bulletCount - 5 + 1);
            firstBulletLocX = weapon.GetComponent<SpriteRenderer>().bounds.min.x + bulletDistance;
            for(int i = 0; i < bulletCount - 5; i++){
            Vector3 firstBulletSpawnLoc = new Vector3(firstBulletLocX + (i * bulletDistance),
            weapon.GetComponent<SpriteRenderer>().bounds.max.y + 1,
            0);
            
            Instantiate(bullet, firstBulletSpawnLoc, new Quaternion(0,0,0,0));
        }
        }
        

    }
}
