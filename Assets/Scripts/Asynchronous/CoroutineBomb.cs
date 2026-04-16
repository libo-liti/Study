using System;
using System.Collections;
using UnityEngine;

public class CoroutineBomb : MonoBehaviour
{
    private Coroutine bombCoroutine;
    private bool iscancle;

    private void Start()
    {
        bombCoroutine = StartCoroutine(BombRoutine());
    }

    private IEnumerator BombRoutine()
    {
        yield return new WaitForSeconds(3f);
        
        if(iscancle)
            yield break;
        Explode();
    }

    private void OnDisable()
    {
        StopCoroutine(bombCoroutine);
    }

    private void Explode()
    {
        
    }
}
