using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using Random = UnityEngine.Random;

public class JobTest : MonoBehaviour
{

    
    private void Start()
    {
        NativeArray<char> result = new NativeArray<char>(5, Allocator.TempJob); 
        var jobAList = new NativeArray<JobHandle>(5, Allocator.TempJob);
        string resultStr = null;

        //for (int i = 0; i < jobAList.Length; i++)
        //{
        //    jobAList[i] = new JobA()
        //    {
        //        result = result,
        //        i = i,
        //    }.Schedule();
        //}


        jobAList[0] = new JobA()
        {
            result = result,
            i = 1,
        }.Schedule();


        var dependecies = JobHandle.CombineDependencies(jobAList);

        var jobBHandle = new JobB()
        {
            result = result,
        }.Schedule(dependecies);

        jobBHandle.Complete();
        resultStr = new string(result.ToArray());
        Debug.Log(resultStr);

        jobAList.Dispose();
        result.Dispose();
    }

}
