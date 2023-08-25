using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{

    [SerializeField] private GameObject[] KeyUbications;
    [SerializeField] private GameObject KeyObject;
    [SerializeField] private GameObject[] Coin;

    private void Awake()
    {
        SpawnKey(); SpawnCoin();
    }

    private void SpawnKey()
    {
        int spawn = Random.Range(0, KeyUbications.Length);
        GameObject.Instantiate(KeyObject, KeyUbications[spawn].transform.position, Quaternion.identity);
        //el int spawn agarra un valor dado entre 0 y el tamaño del array de ubicaciones al azar, esto le permite al instantiate
        //tener una ubicacion aleatoria desde la cual la llave spawneara cada vez que se inicie el juego
    }

    private void SpawnCoin()
    {
        int coins = (Coin.Length - 1);

        foreach (GameObject coin in Coin)
        {
            int spawn = Random.Range(0, KeyUbications.Length);
            GameObject.Instantiate(Coin[coins], KeyUbications[spawn].transform.position, Quaternion.identity);
        }
        //el loop de for each agarrara la cantidad de monedas que posee coins y se repetira tantas veces como halla fragmentos del espejo
        //el int spawn esta dentro del loop para que se genere un nuevo valor cada vez que se repita un ciclo.
        //IMPORTANTE: es enteramente posible que los fragmentos spawneen en una misma posicion a ellos mismos o a la llave.
    }
}
