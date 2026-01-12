using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);
        // 벽의 x값이 -10 이하면 게임오브젝트 삭제
        if (transform.position.x < -10) 
        {
            Destroy(gameObject);
        }
    }
}
