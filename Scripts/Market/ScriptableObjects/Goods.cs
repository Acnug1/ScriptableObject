using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Goods : ScriptableObject
{
    [SerializeField] protected string Label;
    [SerializeField] protected string Description;
    [SerializeField] protected int Price;

    public abstract void ShowInfo(); // в ScriptableObject мы можем работать, как с простым объектом, в том числе вызывать методы или сделать его абстрактным
}
