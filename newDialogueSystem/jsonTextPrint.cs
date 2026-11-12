//외부 json함수 newtonsoft를 이용할 거다 -> unity에서 다운 받을 수 있음

using UnityEngine;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
public class jsonTextPrint : MonoBehaviour
{
    public static jsonTextPrint instance;
    public TextAsset jsonFile;

    private DialogueParent dialogueData;
    void Awake(){
        if(instance == null){ㅏ
            instance = this;
            DonDestroyOnLoad(this);
        }

        else
        {
            Destroy(this);
        }
        dialogueData =
            JsonConvert.DeserializeObject<DialogueParent>(
                jsonFile.text
            );

    }

    //나중에 json파일이 많아지게 된다면 매개변수에서 검증을 거치고 들어가는 걸로 변경
    

    public void SelectChoice(DialogueChoice choice)
    {
        string nextID = choice.nextDialogueID;

        DialogueEntry entry = dialogueData.dialogues
            .Find(x => x.id == nextID);

        if (entry == null)
            return;

        dialogueUI.Show(entry.name, entry.text);
    }

}