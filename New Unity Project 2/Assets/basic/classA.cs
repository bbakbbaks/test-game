using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct StructA
{
    public int m_nData;
    public StructA(int data)
    {
        m_nData = data;
    }
    //void SetData(int data)
    //{
    //    m_nData = data;
    //}
    //다음과 같이 셋 겟을 한꺼번에 만들거나 하나만 사용가능.
    public int Data
    {
        get { return m_nData; }
        set { m_nData = value;/*자동으로 매게변수를 받아줌*/ }
    }

}

public class classA {
    public int m_nData;
    public classA(int data)
    {
        m_nData = data;
    }
  
    public int Data
    {
        get { return m_nData; }
        set { m_nData = value;/*자동으로 매게변수를 받아줌*/ }
    }

}
