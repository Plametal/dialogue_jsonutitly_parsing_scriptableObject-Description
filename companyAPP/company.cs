using UnityEngine;
using UnityEngine.Scene;
using UnityEngine.Generic;
using UnityEngine.UI;
public class company : MonoBehaviour {
    public static company instance;
    [SerializeField] private gameObject computer;
    //위에서 부터 각 버튼은 SNS, 회사 업무 일정, 업무
    [SerializeField] private Button snsApp;
    [SerializeField] private Button companyDate;
    [SerializeField] private Button companyWork;
    [SerializeField] private Button messageBox;
    //어차피 한 번에 하나밖에 못 열기 때문에
    public bool isOpen;
    
     
}