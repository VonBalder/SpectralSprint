using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botiquin : MonoBehaviour
{
    private int extralives = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.GainLives(extralives);

    }

}
