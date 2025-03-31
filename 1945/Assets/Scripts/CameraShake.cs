using UnityEngine;
using Unity.Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    private CinemachineImpulseSource impulseSource;

    void Start()
    {
        instance = this;
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    //ī�޶� ����ũ ����
    public void CameraShakeShow()
    {
        if(impulseSource!=null)
        {
            //�⺻�������� ���޽� ����
            impulseSource.GenerateImpulse();
        }
    }
    
    void Update()
    {
        
    }
}
