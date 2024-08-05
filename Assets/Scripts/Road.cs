using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,0.01f,0);

        if(transform.position.y <= -19){
            transform.position = new Vector3(0,19,0);
        }
    }
}
