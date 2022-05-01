using Unity.Collections;
using Unity.Jobs;

public struct SortJob : IJob
{
    public NativeArray<int> list;   

    public void Execute()
    {
        list.Sort();
    }
}


public struct JobA : IJob
{
    public NativeArray<char> result;
    public int i;
    public void Execute()
    {
        result[0] = 'a';
        result[1] = i.ToString().ToCharArray()[0];
    }
}

public struct JobB : IJob
{
    public NativeArray<char> result;
    public int i;
    public void Execute()
    {
        result[0] = 'b';
    }
}
