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
    public bool isAvailable;
    public GameObject Inventory;

    void Awake(){
        if(instance == null){
            instance = this;
            DonDestroyOnLoad(this);
        }

        else Destroy(this);

        bookImage.setActive(false);

    }

    void Update()
    {
        if (isAvailable)
        {
            Inventory.setActive(true);
        }
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
}