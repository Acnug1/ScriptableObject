using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Shop/Sword", order = 51)]
public class Sword : Goods
{
    [SerializeField] private float _damage;

    public override void ShowInfo()
    {
        Debug.Log($"Прекрасный меч - {Label}, с виду он {Description}, стоит - {Price} и бьет на {_damage}");
    }
}
