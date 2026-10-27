using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;

public class room : MonoBehaviour {
    public static room instance;

    [SerializeField] private gameObject[] selectionObject;
    [SerializeField] private gameObject television;
    [SerializeField] private gameObject book;
    [SerializeField] private gameObject bookShelf;
    //아직 확인하지 않은 오브젝트를 표시하기 위한 장치
    [SerializeField] private gameObject check;
    //여기 selectionObject들은 딱히 상호 작용할 수 있는 것은 없다고 보면 된다

    private void Start()
    {
        getCheck();
    }
    private void getCheck()
    {
        GameObject checkInstantiate = Instantiate(check);
        for(int i = 0; i < selectionObject.Length; i++)
        {
            
            checkInstantiate.position = selectionObject[i].position;
        }
        checkInstantiate.position = book.position;
        checkInstantiate.position = bookShelf.position;
    }

    private void getOffCheck()
    {
        
    }


}