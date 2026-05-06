using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Door : MonoBehaviour
{
    private Door_Test door;
    public bool is_Enter = false;
    public string[] door_dialogue= {"퍼즐을 풀어볼까?" };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character") == true)
        {
            //Debug.Log("캐릭터랑 닿음");
            is_Enter = true;
            door.Get_Dialogue(is_Enter, door_dialogue, true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Character") == true)
        {
            //Debug.Log("충돌 해제");
            is_Enter = false;
            door.Get_Dialogue(is_Enter, null, false);

        }
    }



    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.FindObjectOfType<Door_Test>();
    }



    // Update is called once per frame
    
}
