using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float JumpFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength += JumpFactor;
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= JumpFactor;
    }
}
