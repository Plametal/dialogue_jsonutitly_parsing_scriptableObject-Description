using UnityEngine;

//이 코드들은 나중에 추가할 부분을 정리해 놓은 부분임
public class player : MonoBehaviour {
    public bool isMove;    
    public static player instance;

    private void Update()
    {
        if(!isMove){
            return;
        }
    }
}