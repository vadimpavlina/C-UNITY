using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1f;
    public bool go = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            go = true;
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            go = false;
        }
        if(go)
        {
            Vector3 pos = transform.position;
            pos.x += speed * 0.04f;
            transform.position = pos;
        }
        
    }
}
