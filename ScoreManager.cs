using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance; // 싱글톤 인스턴스
    public TextMeshProUGUI scoreText; // 점수를 표시할 UI Text
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this; // 싱글톤 인스턴스 설정
        }
        else
        {
            Destroy(gameObject); // 이미 인스턴스가 존재하면 현재 오브젝트 삭제
        }
    }


}

