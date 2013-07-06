using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class BitYota : MonoBehaviour 
{	
	// This method will be called for create instance of bityota
	[DllImport("__Internal")]
		private static extern void _instance();
		public static void instance(){
		print("Hello MOtto");
			instance();	
			print("I am here to see whether it is print or not");
		}
	
	// This method will be used for initialize bityota with appid
	[DllImport("__Internal")]
	    private static extern void _initialize(string appid);
		public static void initialize(string apptrackingid){
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			_initialize(apptrackingid);	
			print("I am here to see whether it is print or not");
		}
	}
	
	
	// This method will be used for initialize bityota with appid and extra params
	[DllImport("__Internal")]
		private static extern void _initializeWithDictionary(string appid,string[] objectdata, string[] keydata);
		public static void initializewithdictionary(string appid,string[] objectdata, string[] keydata){
		_initializeWithDictionary(appid,objectdata,keydata);
	 }
	
	// This method will return id of eventTimer of bityota instance
	[DllImport("__Internal")]
		private static extern int _eventTimer();
		
		public static int eventTimer(){
		return _eventTimer();
	 }
	
	// This method will be used to sendEvent with type and objectdata and key data.
	[DllImport("__Internal")]
		private static extern void _sendEvent(string type,string[] objectdata, string[] keydata);
		public static void sendEvent(string type,string[] objects, string[] keys)
		{
		_sendEvent(type,objects,keys);
	 }
	
	// This method will be used to sendEventWithTimer with type and objectdata and key data and eventTimer
    [DllImport("__Internal")]
		private static extern void _sendEventWithTimer(string type,string[] objectdata, string[] keydata,string eventTimer);
		public static void sendEventWithTimer(string type,string[] objectdata, string[] keydata,string eventTimer){
		_sendEventWithTimer(type,objectdata,keydata,eventTimer);
	}
	
	// This method will be used to flushEvents of Bityota instance
	[DllImport("__Internal")]
		private static extern void _flushEvents();
		public static void flushEvents()
		{
			_flushEvents();
		}
	
	// This method will clear event queue.
	[DllImport("__Internal")]
		private static extern void _clearEventQueue();
		public static void clearEventQueue(){
		_clearEventQueue();
	}
	
	// This method will be used for clear stats.
    [DllImport("__Internal")]
    	private static extern void _clearStats();
       public static void clearStats(){
		_clearStats();
    } 
	
	// This method will be used for set enable stats.
    [DllImport("__Internal")]
    	private static extern void _setStatsEnables(bool state);
		public static void setStatsEnables(bool state){
		_setStatsEnables(state);
    }
	
	// This method will return built stat string.
	
	
	// This method will return event queue size.
    [DllImport("__Internal")]
    	private static extern int _getEventQueueSize();
		public static int getEventQueueSize(){
		return _getEventQueueSize();
    }
	
	// This method will retrun flushing event.
	[DllImport("__Internal")]
     	private static extern bool _getIsFlushingEvents();
		public static bool getIsFlushingEvents(){
		return _getIsFlushingEvents();
    }
	
	//This method will be used to set api url.
    [DllImport("__Internal")]
    	private static extern void _apiUrl(string api);
		public static void apiUrl(string api){
       	_apiUrl(api);
    }
	
	//This method will be used to set config sync period minutes.
    [DllImport("__Internal")]
    	private static extern void _tcConfigSyncPeriodMins(int min);
		public static void tcConfigSyncPeriodMins(int min)
    {
        _tcConfigSyncPeriodMins(min);
    } 
	
	// This method will be used to set tracking code of bityota.
	[DllImport("__Internal")]
	 private static extern void _trackingCode(string track);
     	public static void trackingCode(string tracknumber){
		_trackingCode(tracknumber);
	}
	
}


