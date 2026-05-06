using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaintainManager_Test : MonoBehaviour
{
    public static MaintainManager_Test Instance;

    //public Color TeamColor;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
