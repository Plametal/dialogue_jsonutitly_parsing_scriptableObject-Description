using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public SpriteRenderer[] sprite;
    public List<GameObject> InInventoryItem = new List<GameObject>();
    public List<int> InInventoryItemID = new List<int>();
    public static inventory instance;
    public GameObject Inventory;
    public bool isAvailable;

    private int count;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        isAvailable = Inventory != null && Inventory.activeSelf;

        foreach (GameObject slot in InInventoryItem)
        {
            if (slot == null)
            {
                continue;
            }

            SpriteRenderer slotRenderer = slot.GetComponent<SpriteRenderer>();
            if (slotRenderer != null)
            {
                slotRenderer.enabled = false;
            }

            slot.SetActive(false);
        }
    }

    public void checkItem(int id)
    {
        if (InInventoryItemID.Contains(id))
        {
            Debug.Log("이미 존재하는 아이템입니다.");
            return;
        }

        if (sprite == null || id < 0 || id >= sprite.Length || sprite[id] == null)
        {
            Debug.LogWarning($"유효하지 않은 아이템 ID입니다: {id}");
            return;
        }

        if (InInventoryItem == null || count >= InInventoryItem.Count ||
            InInventoryItem[count] == null)
        {
            Debug.LogWarning("사용 가능한 인벤토리 슬롯이 없습니다.");
            return;
        }

        GameObject slot = InInventoryItem[count];
        SpriteRenderer slotRenderer = slot.GetComponent<SpriteRenderer>();
        if (slotRenderer == null)
        {
            Debug.LogWarning($"인벤토리 슬롯에 SpriteRenderer가 없습니다: {slot.name}");
            return;
        }

        slotRenderer.sprite = sprite[id].sprite;
        slotRenderer.enabled = true;
        slot.SetActive(true);
        InInventoryItemID.Add(id);
        count++;
    }

    public void touchUI()
    {
        // 관련 오브젝트의 설명 표시 및 행동력 소모 처리
    }

    public void InventoryUI()
    {
        if (Inventory == null)
        {
            Debug.LogWarning("Inventory 오브젝트가 할당되지 않았습니다.");
            return;
        }

        isAvailable = !Inventory.activeSelf;
        Inventory.SetActive(isAvailable);
    }

    public void resetInventory()
    {
        InInventoryItemID.Clear();
        count = 0;

        foreach (GameObject slot in InInventoryItem)
        {
            if (slot == null)
            {
                continue;
            }

            SpriteRenderer slotRenderer = slot.GetComponent<SpriteRenderer>();
            if (slotRenderer != null)
            {
                slotRenderer.enabled = false;
                slotRenderer.sprite = null;
            }

            slot.SetActive(false);
        }

        isAvailable = false;
        if (Inventory != null)
        {
            Inventory.SetActive(false);
        }
    }
}
