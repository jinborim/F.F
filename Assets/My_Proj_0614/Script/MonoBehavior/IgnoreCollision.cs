using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 두 물체 간 충돌 무시코드
public class IgnoreCollision : MonoBehaviour
{
    public GameObject objcet1;
    public GameObject object2;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(objcet1.GetComponent<BoxCollider2D>(), object2.GetComponent <BoxCollider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
