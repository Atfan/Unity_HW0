using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScripts : MonoBehaviour
{
    [SerializeField]
    private const float max_position_y =10.0f;
    [SerializeField]
    private float speed=0f;
    [SerializeField]
    private float acceleration = -0.5f;
    private float curent_max_position_y = max_position_y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (transform.position.y > 0)
        {
            speed += acceleration*0.01f;
        }
        if (transform.position.y <= 0)
        {
            curent_max_position_y =curent_max_position_y/3;
            acceleration =0f;
            speed = 0;
        }
        // if (acceleration > 0 && transform.position.y > curent_max_position_y)
        // {
        //     acceleration *= -1f;
        //     speed = acceleration * Time.deltaTime; 
        // }
        
        transform.Translate(0, speed, 0);
    }
}
