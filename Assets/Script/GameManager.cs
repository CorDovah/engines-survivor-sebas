using Cysharp.Threading.Tasks;
using Map.views;
using Player.controllers;
using Player.views;
using UnityEngine;
using Utils.AdresableLoader;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private PlayerView playerViewSource; 
    private void Awake()
    {
        if(Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            CreateGame().Forget();
        }
    }

    private async UniTaskVoid CreateGame()
    {
        var mapView = await AdresableLoader.InstantiateAsync<IMapView>("Map_Default");
        var playerView = await AdresableLoader.InstantiateAsync<IPlayerView>("Player_Default");
        IPlayerController playerController = new PlayerController(playerView);
    }
}
