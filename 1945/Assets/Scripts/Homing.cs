using UnityEngine;

public class Homing : MonoBehaviour
{
    public GameObject target;  //�÷��̾�
    public float Speed = 3f;
    Vector2 dir;
    Vector2 dirNo;


    void Start()
    {
        //�÷��̾� �±׷� ã��
        target = GameObject.FindGameObjectWithTag("Player");
        //A - B  A�ٶ󺸴� ����     �÷��̾� - �̻��� 
        dir = target.transform.position - transform.position;
        //���⺤�͸� ���ϱ� �������� ����ȭ �븻 1�� ũ��� �����.
        dirNo = dir.normalized;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(dirNo * Speed * Time.deltaTime);
    }
}
