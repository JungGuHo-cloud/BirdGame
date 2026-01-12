using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float gravity = 10f;
    public float accel = 10f;
    float v;

    public AudioClip upSound;
    public AudioClip downSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        v = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         *  Input         : 키 관련, 매 프레임마다 재설정 되므로 update에서 호출
         *  GetButtonDown : 지정된 키를 누르는 순간 true값 반환
         *  GetButtonUp   : 지정된 키를 떼는 순간 true값 반환
         *  GetButton     : 해당 키를 누르는 동안 true값 반환
         *  GetComponent  : 같은 object에 붙어있는 다른 컴포넌트 기능 가져옴
         *  AudioSource   : AudioSource 컴포넌트
         *  PlayOneShot   : 효과음을 한번 플레이 할 때
         */

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<AudioSource>().PlayOneShot(upSound);
        }
        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<AudioSource>().PlayOneShot(downSound);
        }

        if ( Input.GetButton("Jump") )
        {
            v -= accel * Time.deltaTime;
        }
        else
        {
            v += gravity * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        transform.Translate(Time.fixedDeltaTime * v * Vector2.down);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            float score = GameManager.Instance.score;

            // score 점수 저장 후 저장
            PlayerPrefs.SetInt("Score", (int)score);
            PlayerPrefs.Save();

            SceneManager.LoadScene("GameOverScene");
        }
    }
}
