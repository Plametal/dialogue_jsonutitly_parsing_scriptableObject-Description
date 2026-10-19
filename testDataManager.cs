using System.Diagnostics;
using UnityEngine;

public class JsonExampleManager : MonoBehaviour
{
    void Start()
    {
        // 1. Resources 폴더에서 JSON 파일 로드
        // Assets 폴더 밑에 "Resources" 라는 이름의 폴더를 만들고, 그 안에 PlayerData.json 파일을 넣어주세요.
        TextAsset jsonDataFile = Resources.Load<TextAsset>("PlayerData"); // 파일 이름만 (확장자 제외)

        if (jsonDataFile != null)
        {
            string jsonString = jsonDataFile.text;
            Debug.Log("로드된 JSON 원본: " + jsonString);

            // 2. JSON 문자열을 PlayerData 객체로 변환 (역직렬화)
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(jsonString);

            // 3. 데이터 활용
            if (playerData != null)
            {
                Debug.Log("maxActivation" + playerData.maxActivation);
                Debug.log("currentActivation" + playerData.currentActivation);
                Debug.Log("plaerPostion" + playerData.playerPos);
                Debug.Log("maxActivation" + playerData.maxActivation);
                Debug.Log("currentDialogue" + playerData.currentDialogue);
                Debug.Log("currentSelection" + playerData.currentSelection); 
                
            }
            else
            {
                Debug.LogError("JSON 파싱 실패!");
            }

            // (선택) PlayerData 객체를 다시 JSON 문자열로 변환 (직렬화)
            // true를 넣으면 예쁘게 정렬된 형태로 출력됩니다.
            string newJsonString = JsonUtility.ToJson(playerData, true);
            Debug.Log("다시 직렬화된 JSON: " + newJsonString);

        }
        else
        {
            Debug.LogError("Resources 폴더에서 PlayerData.json 파일을 찾을 수 없습니다!");
        }
    }
}
