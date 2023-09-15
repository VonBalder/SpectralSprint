using UnityEngine;

public class DoorActivation : MonoBehaviour
{
    public static bool Activation; //no puede ser serializado.
    [SerializeField] GameObject Secretlevel;


    void Start()
    {
        Secretlevel.SetActive(false);
    }

    void Update()
    {
        if (Activation == true)
        {
            ActivateDoor();
        }
        else
        {
            return;
        }
    }

    private void ActivateDoor()
    {
        Secretlevel.SetActive(true);
    }

}
