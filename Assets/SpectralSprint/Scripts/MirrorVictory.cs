using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class MirrorVictory : MonoBehaviour
{
    public static int NumMirrors;
    public int NumActivation;
    public string LevelName;


    private void Update()
    {
        if (NumMirrors == NumActivation)
        {
            NextLevel();
        }
        else
        {
            return;
        }

    }
    private void NextLevel()
    {
        MMSceneLoadingManager.LoadScene(LevelName);
    }
}


//el script se preguntara cuantos espejos hay de manera constante (MirrorActivation) y se preguntara el numero exacto (MirrorV)
//Cuando haga eso tambien se preguntara si el numero de espejos es 0, si el numero es 0, avanza al siguiente nivel
//felicidades lograste la victoria espejo


/*    [SerializeField] private GameObject[] Mirrors;
[SerializeField] private int NumMirrors;
public string LevelName;
[SerializeField] private string TagMirror = ("CoinCount");
private void Update()
{
    MirrorActivation();
    MirrorV();
}
private void MirrorActivation()
{
   Mirrors = GameObject.FindGameObjectsWithTag(TagMirror);
}
private void MirrorV()
{
    NumMirrors = Mirrors.Length;

    if (NumMirrors == 0 ) 
    {
        NextLevel();
    }
}

 */

