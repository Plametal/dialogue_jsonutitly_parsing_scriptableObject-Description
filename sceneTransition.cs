using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;
using UnityEngine.UI;
public class sceneTransition : Monobehaviour
{
    public static sceneTransition instance;
    [SerializeField] private Image backGround;
    
    void Awake() {
        if(instance == null){
            instance = this;
            DonDestroyOnLoad(this);
        }   

        else Destroy(this);
    
    }

    //이건 그냥 씬 넘기는 용도 -> 매개변수 blacksceen은임의로 정해놓은 것
    public IEnumulator SceneTransition(string sceneID, bool blackScene)
    {
        fadeIn();
        yield return new WaitForSeconds(3f);
        if(blackScene == true)
        {
            //해당 커맨드가 다 끝나면 그 다음이동
        }

        else
        {
            fadeOut();
        }
    }

    

    private void fadeIn()
    {
        // 맨 마지막 매개변수가 속도인데 나중에 유니티에서 확인해보고 다시 결정
        backGround.a = MathF.moveTowards(100,0, 30);
                
    }

    private void fadeOut()
    {
        backGround.a = MathF.moveTowards(0, 100, 30);
    }

}