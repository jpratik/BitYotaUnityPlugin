using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		//initializing bityota with id
		BitYota.initialize("ZIEXTLXXRVUSSMUF");
	
		//declaring string object
		string[] objects = {"Test1","Test2","Test3"};
		
		//declaring key object
		string[] keys = {"P","Q","R"};
		
		//Sending event to server with id, object and key
		BitYota.sendEvent("testevent1",objects,keys);
		
		//flushing events
		BitYota.flushEvents();
		
		//geting eventtimer
		var timer = BitYota.eventTimer();
		print("Timer is "+timer);
	
		//getting event queue size
		var geteventque = BitYota.getEventQueueSize();
		print("Event queue is "+geteventque);
		
		//getting flush event
		var flushe = BitYota.getIsFlushingEvents();
		print("Flushing event is"+flushe);
	    
		
 
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
}
