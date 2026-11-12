using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text.Json.Serialization;
using UnityEngine;

[Serializable]
public class DialogueParent
{
    public List<DialogueSessionJson>parent;
}

[Serializable]
public class DialogueSessionJson
{
    public string dialougeId;
    public List<DialougeSpeaker> speaker;
    public List<DialogueText> text;
    public List<SelectionText> selection; 
}

[Serializable]
//여기는 사용하지 않을 수도 있음
public class DialougeSpeaker
{
    public string id;
    public string displayName;
}

[Serializable]
public class DialogueText
{
    public string id; //현재 노드에서 몇 번쨰 텍스트
    public string maxActivation; //행동력에 따라 Text가 달라짐
    public string speakerId; //현재 노드에서 말하고 있는 화자
    public string text; //현재 노드에서 출력되고 있는 메시지
    public string nodeName; //현재 어느 노드에서 작동하는지
}
//파싱은 한 번만 하면 됨 -> 그 후로는 scriptableobject에서 id등을 연동해서 연출할 예정

[Serializable]
public class SelectionText
{
    public string maxActivation; //여기는 행동력
    public string first; //여기서 확인을 한 번 했는지 확인 -> 조사한다와 관련있기 때문
    public List<string> choiceText; //선택지에 관한 택스트
    public List<string> selectionResult;
    //public string choiceNode; //행동력과 관련이 되어 있는지 확인
    //마지막은 뭘 할지 아직 미정
}