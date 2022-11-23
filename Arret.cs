using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

public class Arret : MonoBehaviour
{
    WebSocket ws;
    // Start is called before the first frame update
    void Start()
    {
        ws = new WebSocket("ws://192.168.10.233:1880/ws/Arret");
        ws.Connect();
    }

    // Update is called once per frame
    public void SendArret()
    {
        ws.Send("0");
    }
}
