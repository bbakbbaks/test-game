using System.Collections;
using System.Collections.Generic;
using UnityEngine; // 유니티의 라이브러리를 가져다 씀

public class basic : MonoBehaviour//유니티에서 스크립트를 작성할때 가장 기본적인 상속클래스
{
    StructA m_sStruct;
    classA m_cClass;//객체 //classA* m_pClass;
    List<classA> m_listclassA; //std::vector(동적배열)와 같다.
    LinkedList<classA> m_linkedlistclassA; //std::list와 같다.
    Dictionary<string, classA> m_dicclassA;//std::map
    // Use this for initialization
    void Start () {
        //MonoBehaviour로 부터 상속받은 멤버들.
        //컴포넌트나 게임오브젝트 정보등을 가지고 있다.
        this.transform.position = new Vector3(0, 0, 0);

        //구조체는 정적할당됨.
        m_sStruct = new StructA(200);//생성자함수호출
        //m_sStruct.Data = 10;//set사용
        SetDataStruct(m_sStruct, 20);
        Debug.Log("StructData:" + m_sStruct.Data);//get사용
        m_cClass = new classA(100);//인스턴스(동적할당)
        //생성된 인스턴스는 가비지컬렉션에 의해 관리되므로 해제할 필요가 없다
        //m_cClass.Data = 20;
        SetDataClass(m_cClass, 10);
        Debug.Log("ClassData:" + m_cClass.Data);
        string addplus = "A" + "d" + "d";//더하기를 하여 문자열을 생성
        string addformat = string.Format("{0}{1}{2}", "A", "d", "d");//포맷함수를 이용하여 문자열생성
        //문자열을 합칠때는 이러한형식을 쓰는것이 오버헤드가 적다.
        Debug.Log(string.Format("{0}/{1}", addplus, addformat));

    }
	
    void SetDataStruct(StructA s, int data)
    {
        s.Data = data;
    }
    void SetDataClass(classA s, int data)
    {
        s.Data = data;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
