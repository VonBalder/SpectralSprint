using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class QuestWindow : MonoBehaviour
{
    [SerializeField]
    private GameObject window;
    [SerializeField]
    private int closingtime = 3;

    private void Start()
    {
        StartCoroutine(OpenWindow(2));
    }

    public void OnContinuar()
    {
        StartCoroutine(CloseWindow(0));
    }
    IEnumerator OpenWindow(int sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        window.SetActive(true);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
        StartCoroutine(CloseWindow(closingtime));
    }

    IEnumerator CloseWindow(int sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        window.SetActive(false);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
        
    }

}
