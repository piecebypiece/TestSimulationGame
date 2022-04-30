using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 모노 기반 싱글톤 클래스이다.
/// 사용자가 미리 시작씬에 배치해 놓아야한다.
/// </summary>
public class MonoSingleton<T> : MonoBehaviour where T : class
{
    public static T Instance = null;

    void Awake()
    {
        if(Instance != null)
		{
            throw new System.Exception("Singleton is aready exisit");
		}
        Instance = this as T;
        DontDestroyOnLoad(this);
    }
}
