using UnityEngine;
using UnityEngine.UI;
public class startMenu : MonoBehaviour
{
    public static startMenu instance;
    public Button[] menuOption;
    
    private void selectMenuOption()
    {
        if (menuOption[0].onClicked)
        {
            //start(첫 시작)    
        }

        else if (menuOption[1].onClicked)
        {
            //load
        }

        else if (menuOption[2].onClicked)
        {
            //setting
            /*
            마스터 볼륨
            나머지 볼륨
            텍스트 속도

            */
        }

        else if (menuOption[3].onClicked)
        {
            //credits
            /*  
            


            */
        }

    }
}