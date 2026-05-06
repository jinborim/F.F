using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dagger : MonoBehaviour
{
    private HP_Manager hp_manger;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            Destroy(gameObject, 0.02f);
            if (collision.gameObject.CompareTag("Character"))
            {
                hp_manger.Damaged(damage);
            }


        }



    }

    // Start is called before the first frame update
    void Start()
    {
        hp_manger = GameObject.FindObjectOfType<HP_Manager>();
    }

    private void OnBecameInvisible()//화면밖으로 나갈 때 실행
    {
        // 씬 카메라도 포함이기 때문에 2 by 3 레이아웃으로 해두면 씬 밖으로 나갔을 때 실행된다
        // default 레이아웃에서는 플레이할 때 씬이 보이진 않아서 그냥 화면을 카메라로 인식한다
        Destroy(gameObject);//총알 삭제

    }
}
