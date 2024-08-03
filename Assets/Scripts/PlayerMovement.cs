using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            if(touch.position.x > 140){
                transform.position += transform.right * speed;
            }
            else{
                transform.position -= transform.right * speed;
            }

            print(touch.position);
        }
    }
}
