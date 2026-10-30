using UnityEngine;
using UnityEngine.Generic;
using UnityEngine.UI;
using System.Reflection;
public class inventory : Monobehaviour
{
    public spriteRender[] sprite;
    //1이 없다는 것을 증명
    private enum InventoryItem{
        book = 1,
        mirror = 1,
        note = 1,
        television = 1,
        newspaper = 1

    };

    //여기에 맞게 스프라이트를 넣을 예정 -> 여기는 그냥 empty object취급임
    public List<GameObject> InInventoryItem;
    //몇 번째 아이템인지 확인
    private int count = 0;
    public static inventory instance;

    void Awake(){
        if(instance == null){
            instance = this;
            DonDestroyOnLoad(this);
        }

        else Destroy(this);

        bookImage.setActive(false);

    }

    private void check()
    {
        if (have_mirror) bookImage.gameObject.SetActive(true);
        
    }

    private void touchUI()
    {
        //관련된 해당 오브젝트에 대한 설명 등을 볼 수 있다.
        //이 때 다른 행동을 취할 시에, 무조건 행동력 1소모
    }

    //첫 번째로 하얀방에 왔을 때 한 번만 사용됨
    public void InventoryClear()
    {
        for(int i = 0; i < InventoryItem.Length; i++)
        {
            InventoryItem[i] = 0;
            InInventoryItem[i].sprite = None;
            InInventoryItem[i].gameObject.setActive(false);
        }
        count = 0;
    }

    //아이템을 획득했을 때 
    public void InInventory(int num){
        InventoryItem[num] = 0;
        InInventoryItem[count].gameObject.setActive(true);
        InInventoryItem[count].sprite = sprite[num];
        count++;
    }

    //아이템을 쓰고 버렸을 때
    public void outInventory(int num)
    {
        InventoryItem[num] = 1;
        InInventoryItem[count].gameObject.setActive(false);
        InInventoryItem[count].sprite = None;
        count--;
    }
}