using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status_Renew : MonoBehaviour
{
    public HP_Manager hp;
    Gover_Scene SceneRenew;

    // Start is called before the first frame update
    void Start()
    {
        SceneRenew = GameObject.FindObjectOfType<Gover_Scene>();
        hp = GameObject.FindObjectOfType<HP_Manager>();
        if (hp != null)
        {
            //Destroy(hp.gameObject);
            for(int i=0; i<hp.life.Length; i++)
            {
                hp.life[i].Heart_Health = 100;
                hp.life[i].hp_Heart.fillAmount = 1;
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
