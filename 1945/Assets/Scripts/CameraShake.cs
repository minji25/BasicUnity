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

    //카메라 쉐이크 동작
    public void CameraShakeShow()
    {
        if(impulseSource!=null)
        {
            //기본설정으로 임펄스 생성
            impulseSource.GenerateImpulse();
        }
    }
    
    void Update()
    {
        
    }
}
