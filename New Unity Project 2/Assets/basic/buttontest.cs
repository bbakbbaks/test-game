using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttontest : MonoBehaviour {
    public Text m_cText;
    Button m_cButton;
	// Use this for initialization
    public 
	void Start () {
        //오브젝트로 부터 필요한 컴포넌트를 받아오려면 GetComponent를 이용한다,
        m_cButton = this.GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickEvent()
    {
        m_cText.text = "test";
        m_cButton.colors = ColorBlock.defaultColorBlock;
    }
}
