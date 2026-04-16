using System;
using UnityEngine;

public class ObserverPlayer : MonoBehaviour
{
    public event Action OnDamaged;

    void TakeDamage(int damage)
    {
        OnDamaged?.Invoke();
    }
}
