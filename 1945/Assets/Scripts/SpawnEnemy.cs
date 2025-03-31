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
        float randomX = Random.Range(-2f, 2f); //���� ��Ÿ�� x��ǥ�� �������� �����ϱ�

        //���� �����Ѵ�. randomX������ x��
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

    }
}
