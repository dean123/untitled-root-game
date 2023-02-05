using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class PlayMarimba : MonoBehaviour
{
    [SerializeField]
    private AK.Wwise.Switch sequence;

    [SerializeField]
    private AK.Wwise.Switch instrument;

    private void Start()
    {
        instrument.SetValue(gameObject);
        sequence.SetValue(gameObject);
    }
}
