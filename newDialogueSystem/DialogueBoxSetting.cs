using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueBoxSetting : MonoBehaviour
{
    public static DialogueBoxSetting instance;
    [SerializeFIeld] private GameObject textBox;
    [SerializeField] private GameObject endSign;
    [SerializeField] private TextMeshProGUI text;
    [SerializeFIeld] private TextMeshProGUI talker;
    [SerializeField] private GameObject talkerBox;
    //위에 게임오브젝트를 모아둘 부모 오브젝트
    [SerializeFIeld] private GameObject parentAsset;

    void Awake()
    {
        if(instance == null){
            instance = this;
            DonDestroyOnLoad(this);
        }

        else{
            Destroy(this);
        }
        
        parentAsset.SetActive(false);
    }

    private void showTextBox()
    {
        parentAsset.setActive(true);
    }


}