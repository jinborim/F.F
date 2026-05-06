using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "New Gun/GunType")]
public class GunType_selected : ScriptableObject
{
    public GameObject BulletPrefab;
    public Sprite BulletImage;
    public Gun_Type gun_Type;

    public enum Gun_Type
    {
        None,
        RedGun,
        BlueGun,
        PurpleGun
    }
}
