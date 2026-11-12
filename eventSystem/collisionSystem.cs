using UnityEngine;;

public class collisionSystem : MonoBehaviour, collisionInterface
{
    public void OnCollisionEnter2D(Collision2D target)
    {
        collisionInterface collisionInterface = GetComponent<collisionInterface>();
        if(collisionInterface != null)
        {
            collisionInterface.collisionEnter(target.gameObject);
            DialogueBoxSetting.instance.StartInteraction();
        }
    }

    public void OnCollisionExit2D(Collision2D target)
    {
        collisionInterface collisionInterface = GetComponent<collisionInterface>();
        if(collisionInterface != null)
        {
            collisionInterface.collisionExit(target.gameObject);
        }
    }

    public void OnCollisionStay2D(Collision2D target)
    {
        collisionInterface collisionInterface = GetComponent<collisionInterface>();
        if(collisionInterface != null)
        {
            collisionInterface.collisionStay(target.gameObject);
        }
    }
}