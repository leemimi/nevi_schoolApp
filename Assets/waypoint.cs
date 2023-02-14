using Mapbox.Unity.Utilities;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine;

        

///Set a waypoint to a geo location
public class waypoint : MonoBehaviour
{
    [SerializeField]
    AbstractMap _map;

    [SerializeField]
    float lat;

    [SerializeField]
    float lng;

  void Start()
    {
     Awake();
     OnDestroy();

    }
               protected virtual void Awake()
		{
			if (_map == null)
			{
				_map = FindObjectOfType<AbstractMap>();
			}
			_map.OnInitialized += Query;
			_map.OnUpdated += Query;
		}

		protected virtual void OnDestroy()
		{
			_map.OnInitialized -= Query;
			_map.OnUpdated -= Query;
		}

		void Query()
		{
			 moveWaypointToGeoLocation (this.transform);
		}
void moveWaypointToGeoLocation (Transform waypoint)
    {
    waypoint.transform.MoveToGeocoordinate(lat, lng, _map.CenterMercator, _map.WorldRelativeScale);
    //waypoint.transform.position = new Vector3(lat, 0, lng);
    }
/*void Update()
    {


    }

    public void destination_cafe()
    {
        
        lng = 127.0651662;
        lat = 37.5838728;

        Awake();
        OnDestroy();
    }

    public void destination_Domi()
    {
       
        lng = 126.8718969;
        lat = 37.4364467;

        Awake();
        OnDestroy();

    }

    public void destination_Center()
    { 
        lng = 127.0640776;
        lat = 37.5727343;

        Awake();
        OnDestroy();

    }

    public void destination_C6()
    {
        lng = 127.0575115;
        lat = 37.5727886;

        Awake();
        OnDestroy();

    }
    */
}