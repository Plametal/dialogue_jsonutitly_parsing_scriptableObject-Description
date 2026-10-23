using UnityEngine;
using UnityEngine.UI;
//여기에서 하는 일은 pc의 정보를 입력하는 일이다.
public class startMenu : MonoBehaviour
{
    public static startMenu instance;
    public DropDown[] selection;
    public TMP_InputField[] textInput;
    public Button startGame;
    

    public void sendText()
    {
        
    }

    public void isTextNull()
    {   
        for(int i = 0; i < textInput.Length;i++){
            if (string.IsNullOrEmpty(textInput[i].text.Trim())){
                pass;
            }

        }
    }

    //입력이 다 끝난 함수
    private void isEnd()
    {
        if (startGame.onClicked)
        {
            //대충씬 이동
        }
    }
}