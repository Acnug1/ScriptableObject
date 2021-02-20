using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float _health;

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health <= 0)
            Destroy(gameObject);
    }
}
