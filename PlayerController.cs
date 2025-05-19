using UnityEngine;

// 플레이어 캐릭터의 동작을 제어하는 클래스
public class PlayerController : MonoBehaviour
{
    // 물리 동작을 위한 Rigidbody2D 컴포넌트
    Rigidbody2D playerRigidbody;
    // 애니메이션 제어를 위한 Animator 컴포넌트
    Animator playerAnimator;

    // 게임 시작 시 한 번 실행되는 초기화 함수
    void Start()
    {
        // 필요한 컴포넌트들을 가져옴
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // 매 프레임마다 실행되는 업데이트 함수
    void Update()
    {
        // 오른쪽 방향키를 누르고 있을 때
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 오른쪽으로 이동
            playerRigidbody.linearVelocityX = 2.5f;
            // 캐릭터를 오른쪽 방향으로 설정
            transform.localScale = new Vector3(1, 1, 1);
            // 달리기 애니메이션으로 변경 (상태 1)
            playerAnimator.SetInteger("PlayerState", 1);
        }
        // 왼쪽 방향키를 누르고 있을 때
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 왼쪽으로 이동
            playerRigidbody.linearVelocityX = -2.5f;
            // 캐릭터를 왼쪽 방향으로 설정
            transform.localScale = new Vector3(-1, 1, 1);
            // 달리기 애니메이션으로 변경 (상태 1)
            playerAnimator.SetInteger("PlayerState", 1);
        }
        // 아무 방향키도 누르지 않았을 때
        else
        {
            // 이동 멈춤
            playerRigidbody.linearVelocityX = 0;
            // 대기 애니메이션으로 변경 (상태 0)
            playerAnimator.SetInteger("PlayerState", 0);
        }

        // 스페이스바를 눌렀을 때 (점프)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 위쪽으로 힘을 가해 점프
            playerRigidbody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
        
        // Z키를 눌렀을 때 (공격)
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // 공격 애니메이션 트리거 실행
            playerAnimator.SetTrigger("PlayerAttack");
        }
    }
}
