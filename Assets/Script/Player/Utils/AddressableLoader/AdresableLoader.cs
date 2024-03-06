using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace Utils.AdresableLoader
{
    public class AdresableLoader
    {
        public static async UniTask<T> InstantiateAsync<T>(string StyleName)
        {
            var task = Addressables.InstantiateAsync(StyleName).Task.AsUniTask();
            var asset = await task;
            return asset.GetComponent<T>();
        }
    }
}