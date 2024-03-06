using Cysharp.Threading.Tasks;
using Map.controllers;
using Map.views;
using UnityEngine;

namespace Map.controllers
{
    public class MapController : IMapController
    {
        private IMapView _mapView;
        public MapController(IMapView mapView) 
        {
            _mapView = mapView;
        }

    }
}
