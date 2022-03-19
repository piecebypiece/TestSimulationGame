using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��� ��� �̱��� Ŭ�����̴�.
/// ����ڰ� �̸� ���۾��� ��ġ�� ���ƾ��Ѵ�.
/// </summary>
public class MonoSingleton : MonoBehaviour
{
    public static MonoSingleton Instance = null;

    void Awake()
    {
        if(Instance == null)
		{
            throw new System.Exception("Singleton is aready exisit");
		}
        Instance = this;
        DontDestroyOnLoad(this);
    }
}
