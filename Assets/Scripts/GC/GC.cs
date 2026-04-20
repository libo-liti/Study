using System.Text;
using UnityEngine;

public class GC : MonoBehaviour
{
    StringBuilder sb = new StringBuilder();

    // ✅ 좋은 예 - 전역변수로 한 번만 생성 후 재사용
    Vector3 direction = new Vector3(1f, 0f, 0f);
    int[] arr = new int[10];
    
    void Update()
    {
        // ❌ 나쁜 예 - 1초에 60개 쓰레기 생성
        Vector3 direction = new Vector3(1f, 0f, 0f);
        int[] arr = new int[10];
        
        // ❌ 나쁜 예 - 모든 string 연산이 새 객체 생성
        string name = "Player";
        name = "Enemy";           // 새 객체 생성 💥
        name = name.ToUpper();    // 새 객체 생성 💥
        name += "!";              // 새 객체 생성 💥
        
        // ✅ 좋은 예 - StringBuilder는 기존 객체 수정
        sb.Clear();
        sb.Append("Position: ");
        sb.Append(transform.position);
        Debug.Log(sb.ToString());
    }
}
