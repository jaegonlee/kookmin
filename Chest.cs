using UnityEngine;

// 보물상자의 동작을 제어하는 클래스
public class Chest : MonoBehaviour
{
    // 상자의 애니메이션을 제어하기 위한 Animator 컴포넌트
    Animator chestAnimator;

    // 게임 시작 시 한 번 실행되는 초기화 함수
    void Start()
    {
        // Animator 컴포넌트를 가져옴
        chestAnimator = GetComponent<Animator>();        
    }

    // 매 프레임마다 실행되는 업데이트 함수
    void Update()
    {
        // 현재는 사용하지 않음
    }

    // 다른 오브젝트가 트리거(충돌 영역)에 들어왔을 때 자동으로 호출되는 함수
    void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 오브젝트가 "Player" 태그를 가지고 있는지 확인
        if (collision.CompareTag("Player"))
        {
            // 상자 열기 애니메이션 재생
            chestAnimator.SetTrigger("ChestOpen");
            // 콘솔에 아이템 획득 메시지 출력
            Debug.Log("아이템을 획득했습니다!");
        }
    }
}
