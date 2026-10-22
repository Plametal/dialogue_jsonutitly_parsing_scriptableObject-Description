
/*직렬화 가능한 데이터부터 만든다
JSON과 ScriptableObject 양쪽에서 같은 구조를 쓰려면 런타임 오브젝트 참조보다 순수한 값으로 시작하는 편이 좋다.
필요한 변수는 나중에 찾아서 다시 정리
*/
using System;
using System.Collections.Generic;
using UnityEngine;

//enum 상수형 집합을 의미하며,기본은 int형으로 지내며, 숫자를 지정하지 않을 경우, 0부터 시작한다.

//각 노드가 무슨 역할을 하는지 나타내기 위한 장치
public enum DialogueNodeType
{
    Line, //화자의 한 줄 대사 표시
    Choice, //플레이어가 선택할 수 있는 항목 표시
    Branch, //조건을 검사해 자동으로 다음 노드 결정
    Command, //카페말, 사운드 같은 연출 부분을 실행
    End // 대화 종료
}

//텍스트 진행 상황을 나타내준다
public enum DialogueCommandTiming
{
    OnEnter, //엔터키를 입력했을 때, 해당 텍스트 문장 전부 출력
    OnTextComplete, //텍스트가 다 출력된상황
    OnExit //현재 진행 중인 텍스트를 넘어서 다음 문장으로 이동
}

public enum DialogueSpeakerSlot
{
    Left,
    Right,
    Center
}

//선택지를 고르는 부분에서 해당 선택지를 숨길 것인지 선택하는 부분
public enum UnavailableChoiceMode
{
    Hidden, //해당 선택지를 숨기겠다
    Disabled //해당 선택지를 보여주겠다.
}

[Serializable]
public sealed class DialogueGraphData
{
    public string dialogueId;
    public string stringTable;
    public string entryNodeId;
    public List<DialogueNodeData> nodes = new();
}

[Serializable]
public sealed class DialogueNodeData
{
    public string nodeId; //노드에서 텍스트 위치
    public DialogueNodeType type; //현재 노트 종류

    public string speakerId; //해당 노드를 말하는 화자
    public DialogueSpeakerSlot speakerSlot;
    public string textKey; //해당하는 문장
    public string portraitId; //초상화 부분
    public string emotionId; //감정표현 부분

    public string nextNodeId; //현재 노드에서 브랜치 등으로 다음으로 이동할 노드를 확인
    public List<DialogueChoiceData> choices = new();
    public List<DialogueBranchData> branches = new();
    public List<DialogueCommandData> commands = new();

    public Vector2 editorPosition;
}

[Serializable]
public sealed class DialogueChoiceData
{
    public string choiceId; //choice노드에서 선택한 선택지
    public string textKey; //해당 선택된 부분의 텍스트
    public string targetNodeId; //choice에 의해 그 다음 정해진 노드
    public UnavailableChoiceMode unavailableMode; //해당 선택지를 보여줄 지 판단
    public List<DialogueConditionData> conditions = new();
    public List<DialogueEffectData> effects = new();
}

[Serializable]
public sealed class DialogueBranchData
{
    public string targetNodeId; //브랜치에서 다음으로 이동할 노드를 확인
    public List<DialogueConditionData> conditions = new();
}

[Serializable]
public sealed class DialogueCommandData
{
    public DialogueCommandTiming timing; 
    public string commandId; //어떤 커맨드를 실행할지
    public string argument;
    public float number;
}