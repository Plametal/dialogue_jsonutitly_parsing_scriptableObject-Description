# dialogue_jsonutitly_parsing_scriptableObject-Description

## `playerData.json` 대화 그래프 예시

`playerData.json`에는 기존 플레이어 데이터와 `graph` 대화 그래프 예시가 함께 들어 있습니다. `graph`의 필드 구조는 `DialogueAsset`의 `graph` 필드와 `gialogueManager.cs`의 직렬화 데이터 클래스에 맞춘 것입니다.

JSON 표준은 주석을 지원하지 않습니다. 파일 안에 `//` 또는 `/* */` 주석을 넣으면 Unity `JsonUtility`로 읽을 때 문제가 될 수 있으므로, 이 문서에서 각 필드의 의미를 설명합니다.

### 그래프 필드

| 필드 | 의미 | 예시 |
| --- | --- | --- |
| `dialogueId` | 대화 그래프를 식별하는 고유 ID | `cafe_intro` |
| `stringTable` | 대사 키를 찾을 문자열 테이블 이름 | `DialogueText` |
| `entryNodeId` | 대화를 시작할 노드의 `nodeId`. `nodes` 안에 실제로 존재해야 합니다. | `start` |
| `nodes` | 대화의 각 노드를 담는 배열 | 시작 대사, 선택지, 종료 노드 |

### 노드 필드

| 필드 | 의미 |
| --- | --- |
| `nodeId` | 노드의 고유 ID. `nextNodeId`나 선택지의 `targetNodeId`에서 이 값을 참조합니다. |
| `type` | 노드 종류를 나타내는 `DialogueNodeType` 숫자 값입니다. `0` Line(대사), `1` Choice(선택지), `2` Branch(조건 분기), `3` Command(연출 명령), `4` End(종료)입니다. |
| `speakerId` | 대사를 말하는 캐릭터 ID |
| `speakerSlot` | 화자 표시 위치입니다. `0` Left, `1` Right, `2` Center입니다. |
| `textKey` | 문자열 테이블에서 대사/선택지 문장을 찾을 키. JSON 안에 실제 문장 대신 키를 넣습니다. |
| `portraitId` | 사용할 캐릭터 초상화 ID |
| `emotionId` | 캐릭터 표정/감정 ID |
| `nextNodeId` | 다음으로 이동할 노드 ID. Choice 노드에서는 각 선택지의 `targetNodeId`를 사용합니다. |
| `choices` | Choice 노드의 선택지 목록. 다른 노드에서는 빈 배열로 둡니다. |
| `branches` | Branch 노드의 조건별 이동 경로 목록 |
| `commands` | 노드에서 실행할 연출/게임 명령 목록 |
| `editorPosition` | 에디터 그래프에서 노드를 배치할 좌표. `x`, `y`를 가집니다. |

### 선택지 필드

| 필드 | 의미 |
| --- | --- |
| `choiceId` | 선택지를 식별하는 고유 ID |
| `textKey` | 문자열 테이블에서 선택지 문구를 가져올 키 |
| `targetNodeId` | 이 선택지를 고르면 이동할 노드의 `nodeId` |
| `unavailableMode` | 선택할 수 없을 때의 표시 방식입니다. `0` Hidden(숨김), `1` Disabled(비활성 표시)입니다. |
| `conditions` | 이 선택지를 표시/선택할 조건 목록 |
| `effects` | 이 선택지를 골랐을 때 적용할 효과 목록 |

현재 코드에는 `DialogueConditionData`와 `DialogueEffectData`의 필드 정의가 포함되어 있지 않아, 예시에서는 두 배열을 비워 두었습니다. 조건/효과 데이터를 추가할 때는 해당 데이터 클래스와 JSON 형식을 먼저 정의해야 합니다.

### 예시 대화의 진행 순서

1. `entryNodeId`인 `start`에서 카페 직원의 인사 대사가 표시됩니다. `type: 0`은 Line이며, `nextNodeId`는 `ask_drink`입니다.
2. `ask_drink`는 `type: 1`인 Choice 노드입니다. 커피를 고르면 `coffee_reply`, 차를 고르면 `tea_reply`로 이동합니다.
3. 각 응답 노드는 `type: 0`인 대사 노드이며 다음 노드로 `end`를 지정합니다.
4. `end`는 `type: 4`인 종료 노드입니다.

`textKey`에 해당하는 실제 문구(예: `cafe.intro.greeting`)는 `stringTable`에 등록되어 있어야 합니다. 노드 ID와 참조 ID의 철자가 서로 일치하는지도 확인하세요.