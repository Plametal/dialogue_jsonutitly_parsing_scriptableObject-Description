using UnityEngine;

[CreateAssetMenu(
    fileName = "Dialogue",
    menuName = "Game/Dialogue/Dialogue Graph")]
public sealed class DialogueAsset : ScriptableObject
{
    [SerializeField] private DialogueGraphData graph = new();

    public DialogueGraphData Graph => graph;
}