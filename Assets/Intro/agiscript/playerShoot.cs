using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    private Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // 플레이어 오브젝트에 자식오브젝트로 있는 BulletSpawnPoint 찾아와서 위치 설정 해주기
        bulletSpawnPoint = this.transform.Find("BulletSpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //총알을 만든다 
            /* var bulletGo = Instantiate<GameObject>(this.bulletPrefab);
            bulletGo.transform.position = this.bulletSpawnPoint.position; */
            GameObject BulletGo = Instantiate(bulletPrefab, this.transform.position, transform.rotation);
        }
    }
}
