using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.UI;

public class numberAttackEvent : MonoBehaviour
{
    [SerializeField]private gameObject gaugeBar;
    [SerializeField]private gameObject timingBar;
    private void OnCollisionStay2D(collider2d collision)
    {
        if(collision.gameObject == timingBar && Input.GetKeyDown(space))
        {
            Debug.Log("correct");
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject == timingBar)
        {
            Debug.Log("false");
        }    
    }
}