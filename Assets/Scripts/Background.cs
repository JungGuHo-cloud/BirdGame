using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 3;
    public float size = 19.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x축으로 speed 만큼 -1 이동 Time.deltaTime : 다음 업데이트 까지의 시간텀
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -size)
        {
            transform.Translate(new Vector3(size * 2, 0, 0));
        }
    }
}
