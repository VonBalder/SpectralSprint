<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
>>>>>>> 6409d685336feb0e4f5a2b29cae211406d62847c
using UnityEngine;

public class MirrorCounter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        MirrorVictory.NumMirrors += 1;
    }
}
