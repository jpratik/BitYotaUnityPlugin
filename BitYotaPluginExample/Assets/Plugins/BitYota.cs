using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class BitYota : MonoBehaviour 
{	
	// This method will be called for create instance of bityota
	[DllImport("__Internal")]
	private static extern void _instance();
	
	public static void instance()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
			instance();
	}
	
	// This method will be used for initialize bityota with appid
	[DllImport("__Internal")]
	private static extern void _initialize(string appid);
	
	public static void initialize(string apptrackingid)
	{
			if(Application.platform == RuntimePlatform.IPhonePlayer)
			_initialize(apptrackingid);	
	}
	
	
	// This method will be used for initialize bityota with appid and extra params
	[DllImport("__Internal")]
	private static extern void _initializeWithDictionary(string appid,string[] objectdata, string[] keydata);
	
	public static void initializewithdictionary(string appid,string[] objectdata, string[] keydata)
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_initializeWithDictionary(appid,objectdata,keydata);
	 }
	
	// This method will return id of eventTimer of bityota instance
	[DllImport("__Internal")]
	private static extern int _eventTimer();
		
	public static int eventTimer()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		return _eventTimer();
		
		return 0;
	 }
	
	// This method will be used to sendEvent with type and objectdata and key data.
	[DllImport("__Internal")]
	private static extern void _sendEvent(string type,string[] objectdata, string[] keydata);
		
	public static void sendEvent(string type,string[] objects, string[] keys)
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_sendEvent(type,objects,keys);
	 }
	
	// This method will be used to sendEventWithTimer with type and objectdata and key data and eventTimer
    [DllImport("__Internal")]
	private static extern void _sendEventWithTimer(string type,string[] objectdata, string[] keydata,string eventTimer);
	
	public static void sendEventWithTimer(string type,string[] objectdata, string[] keydata,string eventTimer)
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_sendEventWithTimer(type,objectdata,keydata,eventTimer);
	}
	
	// This method will be used to flushEvents of Bityota instance
	[DllImport("__Internal")]
	private static extern void _flushEvents();
	
	public static void flushEvents()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
			_flushEvents();
	}
	
	// This method will clear event queue.
	[DllImport("__Internal")]
	private static extern void _clearEventQueue();
	
	public static void clearEventQueue()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_clearEventQueue();
	}
	
	// This method will be used for clear stats.
    [DllImport("__Internal")]
    private static extern void _clearStats();
	
    public static void clearStats()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_clearStats();
    } 
	
	// This method will be used for set enable stats.
    [DllImport("__Internal")]
    private static extern void _setStatsEnables(bool state);
	
	public static void setStatsEnables(bool state)
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_setStatsEnables(state);
    }
	
	// This method will return built stat string.
	
	
	// This method will return event queue size.
    [DllImport("__Internal")]
    private static extern int _getEventQueueSize();
	
	public static int getEventQueueSize()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		return _getEventQueueSize();
		
		return 0;
    }
	
	// This method will retrun flushing event.
	[DllImport("__Internal")]
    private static extern bool _getIsFlushingEvents();
	
	public static bool getIsFlushingEvents()
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		return _getIsFlushingEvents();
		
		return false;
    }
	
	//This method will be used to set api url.
    [DllImport("__Internal")]
    private static extern void _apiUrl(string api);
	
	public static void apiUrl(string api)
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
       	_apiUrl(api);
    }
	
	//This method will be used to set config sync period minutes.
    [DllImport("__Internal")]
    private static extern void _tcConfigSyncPeriodMins(int min);
	
	public static void tcConfigSyncPeriodMins(int min)
    {
		if(Application.platform == RuntimePlatform.IPhonePlayer)
        _tcConfigSyncPeriodMins(min);
    } 
	
	// This method will be used to set tracking code of bityota.
	[DllImport("__Internal")]
	private static extern void _trackingCode(string track);
	
    public static void trackingCode(string tracknumber)
	{
		if(Application.platform == RuntimePlatform.IPhonePlayer)
		_trackingCode(tracknumber);
	}
	
}