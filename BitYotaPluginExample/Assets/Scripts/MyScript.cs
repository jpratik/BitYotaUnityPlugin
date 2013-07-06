using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	
		BitYota.initialize("ZIEXTLXXRVUSSMUF");
		//IDictionary openWith = new SortedDictionary<string,string>();
		/*Hashtable ope = new Hashtable();

        // Add some elements to the dictionary. There are no  
        // duplicate keys, but some of the values are duplicates.
		
        ope.Add("txt", "notepad.exe");
        ope.Add("bmp", "paint.exe");
        ope.Add("dib", "paint.exe");
        ope.Add("rtf", "wordpad.exe");*/
	    string[] objects = {"Test1","Test2","Test3"};
		string[] keys = {"P","Q","R"};
		
		BitYota.sendEvent("testevent1",objects,keys);
		BitYota.flushEvents();
		var timer = BitYota.eventTimer();
		print("Timer is "+timer);
	
		var geteventque = BitYota.getEventQueueSize();
		print("Event queue is "+geteventque);
		var flushe = BitYota.getIsFlushingEvents();
		print("Flushing event is"+flushe);
		
//		print(File.testing);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
