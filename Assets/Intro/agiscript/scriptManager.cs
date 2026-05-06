using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptManager : MonoBehaviour
{
    public Autoshoot autoshoot;

    // Start is called before the first frame update
    void Start()
    {
        autoshoot = GameObject.FindObjectOfType<Autoshoot>();
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    IEnumerator sceneManager()
    {
        //총알빵빵빵
        //플레이어 이동+멈춤
        //npc 등장+멈춤
        //npc 대사 출력
        //플레이어 쭉 이동해서 점프맵 시작

        Autoshoot call = GameObject.Find("TestPrefab").GetComponent<Autoshoot>();

        yield return call.StartCoroutine(autoshoot.AutoBullet());

       // +조건
       //함수내용




        yield break;
    }
}
