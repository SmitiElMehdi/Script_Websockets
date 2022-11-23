using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

public class Function : MonoBehaviour
{
    WebSocket ws;
    // Start is called before the first frame update
    void Start()
    {
        ws = new WebSocket("ws://x.x.x.x:1880/ws/Nom_du_noeud_websocket_dans_le_node-red");
        ws.Connect();
    }

    // Update is called once per frame
    public void SendFunction()
    {
        ws.Send("0");
    }
}
