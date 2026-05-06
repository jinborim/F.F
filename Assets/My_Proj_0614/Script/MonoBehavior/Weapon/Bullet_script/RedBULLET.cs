using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBULLET : MonoBehaviour
{
    public MonsterMovement monster;
    Rigidbody2D bulletRd;

    private int damage=10;

    public Boss_Movement boss;
    public Boss_Health boss_health;

    public Monster_ monster_;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("RedEnemy") || collision.gameObject.CompareTag("Boss"))
        {
            Destroy(gameObject, 0.02f);//땅이나 적에 닿으면 총알이 사라짐
            if (collision.gameObject.CompareTag("RedEnemy"))
            {
                //Debug.Log(collision.gameObject.name);
                //Destroy(collision.gameObject, 0.02f);
                monster = collision.gameObject.GetComponent<MonsterMovement>();
                monster.health_manager(damage);
                monster_ = collision.gameObject.GetComponent<Monster_>();
                if (monster_ != null)
                {
                    monster_.GetDamage(damage);
                }

            }
            else if (collision.gameObject.CompareTag("Boss"))
            {
                //보스 체력 깎기
                if (boss!=null&&boss.Boss_is_Beat == false)
                {
                    boss_health.bossDamaged(damage);
                }
            }
            
        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        bulletRd = GetComponent<Rigidbody2D>();
        boss = GameObject.FindObjectOfType<Boss_Movement>();
        boss_health = GameObject.FindObjectOfType<Boss_Health>();
        
    }

    // Update is called once per frame

    private void OnBecameInvisible()//화면밖으로 나갈 때 실행
    {
        // 씬 카메라도 포함이기 때문에 2 by 3 레이아웃으로 해두면 씬 밖으로 나갔을 때 실행된다
        // default 레이아웃에서는 플레이할 때 씬이 보이진 않아서 그냥 화면을 카메라로 인식한다
        Destroy(gameObject);//총알 삭제

    }
}
