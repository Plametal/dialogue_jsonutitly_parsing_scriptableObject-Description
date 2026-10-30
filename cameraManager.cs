using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using UnityEngine;
using Mathf;

public class cameraManager : MonoBehaviour
{
    public static cameraManger instance;
    public Transform player;
    public Transform mainCamera;
    public GameObject cameraRange;
    public float cameraMoveSpeed;

    [SerializeField] private vector2 mapSize;
    private float height, width;
    private float fov;
    [SerializeField] private float minFov;
    [SerializeField] private float maxFov;
    private void Awake(){
        if(instance == null){
            instance = this;
            DonDestroyOnLoad(this);
        }

        else Destroy(this);
        
        transform.position = player.position + Vector(0, 2);
        fov = mainCamera.fieldOfView;
    }

    void Start()
    {
        height = mainCamera.orthographicSize;
        width = height * Screen.width / Screen.height;
    }
    //카메라 제한 범위
    void FixedUpdate()
    {
        
    }

    //player추척 함수 코드 -> 여기에 범위가지 다 넣은 나중에 다시 작성
    void cameraRange(){
        transform.position = Vector2.Lerp(transform.position, player.position + transform.position, Time.deltaTime * cameraMoveSpeed);
        clamp_x = MathF.clamp();
        clamp_y = MathF.clamp();

        transform.position = Vector2.Lerp(clamp_x, clamp_y, -10f);
    }

    public void zoomIn()
    {
        fov = MathF.clamp(fov, minFov, maxFov);
        fov = mainCamera.fieldOfView;
    }

    public void zoomOut()
    {
        fov = MathF.clamp(fov, maxFov, minFov);
        fov = mainCamera.fieldOfView;   
    }
    //방 안이 어두울 때와 밝을 때의 카메라 사이즈를 다르게 설정한다
    //또한 depth도 조정
    public void cameraSize()
    {
        
    }

}