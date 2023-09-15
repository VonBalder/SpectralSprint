using UnityEngine;

public class KeyActivation : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DoorActivation.Activation = true;
    }
}
