using UnityEngine;

public class cleanedObject : MonoBehaviour, collisionInterface
{
    [SerializeField] private GameObject erasedArea;
    [SerializeField] private GameObject erased_Object;
    [SerializeField] private GameObject[] obj;
    private bool isAvailable = true;
    public void collisionEnter(Collision2D target)
    {
        if(isAvailable == true)
        {
            erased_Object.a -=0.33;
        }
    }

    public void collisionExit(Collision2D target)
    {
        isAvailable = false;
    }

    private void eraseObject()
    {
        if(erased_Object.a <= 0.01)
        {
            erased_Object.setActive(false);
        }
    }

    //지워질 오브젝트 위치를 설정
    public void summonObject()
    {
           
        GameObject erased_Object_copy = Instantiate(erased_Object, new Vector3(-erasedArea.position.x, erasedArea.position.y, 0),Quaternion.identity);
        erased_Object_copy.transform.localScale = Vector3.one * Random.Range(0.5f, 1.5f);
        obj.Add(erased_Object_copy);
    }

    void Update()
    {
        eraseObject();
    }



}