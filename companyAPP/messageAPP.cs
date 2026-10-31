using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class messageApp : MonoBehaviour
{
    public static messageApp instance;
    public InputField passwordInput;
    private int password = 0; //아직 미정
    
    //비번 확인하는 창
    public Button connection;
    public TextMeshProGUI connection_text;

    public

    public GameObject mailMessage;
    //0일 때 파일을 열어본 것으로 침
    public enum textSession{
        first = 1,
        second = 1,
        third = 1  
    };
    //enum에서 0이된 숫자를 표기하기 위해서 사용
    public int openNum;

    public GameObject[] textFile;

    void Awake()
    {
        if(instance == null) instance = this;

        else Destroy(this);
    }    

    public void pwCheck()
    {
        if(passwordInput<TextComponent>.text == password && connection.onClicked)
        {
            mailMessage.setActive(true);
        }
    }

    public void targetMessage(GameObject target)
    {
        for(int i = 0; i < textSession.Length; i++)
        {
            if(target.name == textSession[i])
            {
                //r그 약간 비치는 검은 바탕에 글만 나오도록 함
                textSession[i] = 0;
                openNum = i;
            }
        }
    }
}