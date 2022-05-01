using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

namespace VampLike
{
    public partial class PlayerJobSys : SystemBase
    {
        protected override void OnUpdate()
        {
            new PlayerJob().Schedule();
        }
    }
}