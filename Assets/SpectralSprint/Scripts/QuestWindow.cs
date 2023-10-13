using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class QuestWindow : MonoBehaviour
{
    [SerializeField]
    private GameObject window;

    private void Start()
    {
        StartCoroutine(OpenWindow(5));
    }

    public void OnContinue()
    {
        CloseWindow();
    }
    void CloseWindow()
    {
        window.SetActive(false);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
    }

    IEnumerator OpenWindow(int sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        window.SetActive(true);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
    }


}
