using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Event : MonoBehaviour
{
    UnityEvent m_MyEvent;
    private PlayerAvatar playerAvatar;
    void Start()
    {
        playerAvatar = GetComponent<PlayerAvatar>();
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        m_MyEvent.AddListener(Ping);
    }

    void Update()
    {
        if (playerAvatar.health < 1 && m_MyEvent != null)
        {
            print("lol");
            m_MyEvent.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}