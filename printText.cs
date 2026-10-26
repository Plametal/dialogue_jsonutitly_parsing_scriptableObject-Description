using UnityEngine;
using UnityEngine.UI;
//여기에서 하는 일은 pc의 정보를 입력하는 일이다.
public class printText : MonoBehaviour
{
    public static printText instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DonDestroyOnLoad(this);
        }    

        else Destroy(this);
    }


    public static class DialogueJsonLoader
    {
        public static DialogueGraphData Load(TextAsset jsonAsset)
        {
            DialogueGraphData graph =
                JsonUtility.FromJson<DialogueGraphData>(jsonAsset.text);

            if (graph == null)
            {
                throw new System.InvalidOperationException(
                    $"대화 JSON을 읽을 수 없습니다: {jsonAsset.name}");
            }

            return graph;
        }
    }

    private IEnumerator PlayRoutine()
    {
        //여기서 view는 대화가 표시되는 UI창으로 인식될 가능성이 있음
        view.Show();
        currentNodeId = graph.EntryNodeId;
        int automaticStepCount = 0;

        while (!string.IsNullOrWhiteSpace(currentNodeId))
        {
            DialogueNodeData node =
                graph.GetNode(currentNodeId);

            switch (node.type)
            {
                case DialogueNodeType.Line:
                    automaticStepCount = 0;
                    yield return PlayLine(node);
                    currentNodeId = node.nextNodeId;
                    break;

                case DialogueNodeType.Choice:
                    automaticStepCount = 0;
                    yield return PlayChoice(node);
                    break;

                case DialogueNodeType.Branch:
                    currentNodeId = SelectBranch(node);
                    automaticStepCount++;
                    break;

                case DialogueNodeType.Command:
                    yield return commandDispatcher.Execute(
                        node.commands,
                        DialogueCommandTiming.OnEnter);
                    currentNodeId = node.nextNodeId;
                    automaticStepCount++;
                    break;

                case DialogueNodeType.End:
                    currentNodeId = null;
                    break;
            }

            if (automaticStepCount > 128)
            {
                throw new System.InvalidOperationException(
                    "자동 노드 순환을 확인하세요.");
            }
        }

        view.Hide();
    }
}