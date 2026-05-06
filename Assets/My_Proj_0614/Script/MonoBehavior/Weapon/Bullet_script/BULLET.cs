using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BULLET : MonoBehaviour
{
    Rigidbody2D bulletRd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        bulletRd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    private void OnBecameInvisible()//화면밖으로 나갈 때 실행
    {
        // 씬 카메라도 포함이기 때문에 2 by 3 레이아웃으로 해두면 씬 밖으로 나갔을 때 실행된다
        // default 레이아웃에서는 플레이할 때 씬이 보이진 않아서 그냥 화면을 카메라로 인식한다
        Destroy(gameObject);//총알 삭제

    }
}
