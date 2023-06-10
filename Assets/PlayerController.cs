using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 1f;
    public KeyCode UpKey = KeyCode.W;
    public KeyCode DownKey = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKey(UpKey) && transform.position.y <4)
        {
             transform.position += Vector3.up * Time.deltaTime * Speed;
        }
        if(Input.GetKey(DownKey) && transform.position.y >-4)
        {
            transform.position -= Vector3.up * Time.deltaTime * Speed;
        }
    }
}
