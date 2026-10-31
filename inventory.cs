using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystem;
using System.Reflection;
public class inventory : Monobehaviour,IPointerClickHandler
{
    public bool have_book = false;
    public bool have_mirror = false;
    public Image bookImage;
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

    //이걸 눌러야 인벤토리가 등장하는 걸로
    private void bagUI()
    {
        
    }
}