using UnityEngine;

namespace Hooran._Packages.Pooling
{
    [DefaultExecutionOrder(-9999), DisallowMultipleComponent]
    internal sealed class PoolInstaller : MonoBehaviour
    {
        [SerializeField] private PoolContainer[] _pools;

        private void Awake()
        {
            for (var i = 0; i < _pools.Length; i++)
                _pools[i].Populate();
        }

        [System.Serializable]
        private struct PoolContainer
        {
            [SerializeField] private GameObject _prefab;
            [SerializeField, Min(1)] private int _startCount;

            public void Populate()
            {
                _prefab.Populate(_startCount);
            }
        }
    }
}
