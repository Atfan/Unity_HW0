using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float radius =5f;
    public float speed =2f;
    public float angle =0f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        float z = Mathf.Sin(angle) * radius;
        float x = Mathf.Cos(angle) * radius;
        
        transform.position = new Vector3(x,transform.position.y,z);
    }
}
