using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MirrorCounter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        MirrorVictory.NumMirrors += 1;
    }
}
