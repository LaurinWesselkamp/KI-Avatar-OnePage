using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Normal.Realtime;

public class UpdateAusgabe : MonoBehaviour
{
    private RealtimeTransform realtimeTransform;

    // Start is called before the first frame update
    void Start()
    {
        realtimeTransform = GetComponent<RealtimeTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        realtimeTransform.RequestOwnership();
    }
}
