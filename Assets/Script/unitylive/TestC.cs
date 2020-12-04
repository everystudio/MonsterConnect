using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestC : MonoBehaviour
{
    public TestA instance_a;
    public TestB instance_b;

    void Start()
    {
        Debug.Log(instance_a.m_iTestAInt);
        Debug.Log(instance_b.m_iTestBInt);
    }
}
