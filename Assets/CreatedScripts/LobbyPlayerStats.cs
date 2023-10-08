using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyPlayerStats : MonoBehaviour
{
    public TextMesh tm;
    public NetworkRoomPlayerCustom nrpc;
    public void Setup(NetworkRoomPlayerCustom nrpc)
    {
        gameObject.SetActive(true);
        tm.text = nrpc.steamName;
        nrpc.OnSteamIDChanged += OnSteamIdChanged;
        this.nrpc = nrpc;
    }

    private void FixedUpdate()
    {
        if (nrpc == null)
            gameObject.SetActive(false);
    }

    private void OnSteamIdChanged()
    {
        tm.text = nrpc.steamName;
    }
}
