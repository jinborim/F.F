using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_Test : MonoBehaviour
{
    Vector2 destination = new Vector2(9,1.2f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 speed = Vector2.zero;
        transform.position = Vector2.SmoothDamp(transform.position, destination, ref speed, 0.1f);
    }
}
