using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreativeEnemy", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreativeEnemy()
    {
        float randomX = Random.Range(-2f, 2f); //적이 나타날 x좌표를 랜덤으로 생성하기

        //적을 생성한다. randomX랜덤한 x값
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

    }
}
