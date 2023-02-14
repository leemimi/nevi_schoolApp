using Mapbox.Unity.Utilities;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine;

///Set a waypoint to a geo location
public class Waypointt : MonoBehaviour
{
    [SerializeField]
    AbstractMap _map;

    [SerializeField]
    float Latitude_var;

    [SerializeField]
    float Longitude_var;


    public GeoLocationData[] PointsOfIinterest;

    void Start()
    {
        MoveWaypointToGeoLocation(this.transform);

    }

    void Update()
    {


    }

    //The method that sets the waypoint ot the geo location
    private void MoveWaypointToGeoLocation(Transform waypoint)
    {
        waypoint.MoveToGeocoordinate(Latitude_var, Longitude_var, _map.CenterMercator, _map.WorldRelativeScale);
    }
}