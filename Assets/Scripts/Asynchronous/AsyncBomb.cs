using System;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncBomb : MonoBehaviour
{
    // async void — Start() 같은 유니티 이벤트 함수에서만 사용
    async void Start()
    {
        await LoadUserDataAsync();
        StartGame();
    }

    // async Task — 그 외 모든 경우 권장
    async Task BombAsync()
    {
        await Task.Delay(3000);  // 3초 대기

        // 방어 코드 필수!
        if (this == null) return;
        Explode();
    }

    private async Task LoadUserDataAsync()
    {
        await Task.Delay(3000);
    }
    
    private void StartGame()
    {
        
    }
    
    private void Explode()
    {
        
    }
}
