using UnityEngine;

public class cleanUp : MonoBehaviour
{
    [SerializeField] private GameObject erased_Object;
    private bool isAvailable = true;
    private void OnCollisionEnter2D(Collision2D other) {
        if(isAvailable == true)
        {
            erased_Object.a -=0.33;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        isAvailable = false;    
    }

    private void eraseObject()
    {
        if(erased_Object.a <= 0.01)
        {
            erased_Object.setActive(false);
        }
    }

    void Update()
    {
        eraseObject();
    }



}