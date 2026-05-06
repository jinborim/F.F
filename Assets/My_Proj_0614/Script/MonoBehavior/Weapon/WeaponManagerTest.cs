using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManagerTest : MonoBehaviour
{
    public float switchDelay = 1f;
    public GameObject[] weapon;

    private int index = 0;
    private bool isSwitching = false; //딜레이 확인용
    // Start is called before the first frame update
    void Start()
    {
        InitializeWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        // 원형리스트?로 만들어주기위해..(인덱스 값보다 높으면 0으로 초기화하고 낮으면 끝으로 초기화해줌)
        if(Input.GetAxis("Mouse ScrollWheel")>0 && !isSwitching) {
            index++;
            if (index >= weapon.Length)
                index = 0;
            StartCoroutine(SwitchDelay(index));
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && !isSwitching)
        {
            index--;
            if (index < 0)
                index = weapon.Length - 1;
            StartCoroutine(SwitchDelay(index));
        }

        // weapon switching by alphanum
        for (int i = 49; i < 58; i++)
        {
            if (Input.GetKeyDown((KeyCode)i) && !isSwitching && weapon.Length > i - 49 && index != i - 49)
            {
                index = i - 49;
                StartCoroutine(SwitchDelay(index));
            }
        }
    }

    private void InitializeWeapon()
    {//게임 시작 시 0번 인덱스 무기만 Active 하고 나머지는 비활성화로 초기화해줌..
        for (int i = 0; i < weapon.Length; i++)
        {
            weapon[i].SetActive(false);
        }
        weapon[0].SetActive(true);
        index = 0;
    }

    private IEnumerator SwitchDelay(int newIndex)
    {
        //함수가 실행될 때 대기시간을 넣기 위한 IEnumerator..
        // yield 형으로 WaitForSeconds(초)의 리턴값을 리턴해주면 해당 초만큼 대기를 한 후 다음줄부터 실행됨
        isSwitching = true;
        SwitchWeapons(newIndex);
        yield return new WaitForSeconds(switchDelay);
        isSwitching = false;
    }

    private void SwitchWeapons(int newIndex)
    {
        for (int i = 0; i < weapon.Length; i++)
        {
            weapon[i].SetActive(false);
        }
        weapon[newIndex].SetActive(true);
    }
}

