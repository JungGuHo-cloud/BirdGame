using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;

    public GameObject wallPrefabs;
    public float spawnTerm = 4;

    public TextMeshProUGUI scoreLabel;
    
    float spawnTimer;
    public float score;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        score += Time.deltaTime;
        scoreLabel.text = ((int)score).ToString();

        if (spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;

            GameObject obj = Instantiate(wallPrefabs);
            obj.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
        }
    }


}
