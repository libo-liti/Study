using System;
using UnityEngine;
using UnityEngine.Serialization;

public class HPBar : MonoBehaviour
{
    [SerializeField] private ObserverPlayer observerPlayer;
    private void Start()
    {
        observerPlayer.OnDamaged += UpdateHp;
    }

    private void OnDestroy()
    {
        observerPlayer.OnDamaged -= UpdateHp;
    }

    void UpdateHp()
    {
        
    }
}
