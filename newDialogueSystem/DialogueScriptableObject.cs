[System.Serializable]
public class DialogueChoice
{
    public string choiceText;
    public string nextDialogueID;
}

[CreateAssetMenu(menuName = "Dialogue/Data")]
public class DialogueData : ScriptableObject
{
    public string dialogueID;
    public List<DialogueChoice> choices;
}