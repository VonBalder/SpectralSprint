using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class SPCoin : Monobehaviour , MMEventListener<PickableItemEvent>
{ 
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent item)
    {
        contador_monedas++

        if (contador_monedas == 3)
        {
            GameManager.Instance.GainLives(1);
            contador_monedas = 0; //corregir bug donde se ejecutan tantas veces como exista el mismo objeto, lo que hizo el profesor fue ponerlo en la UI mas no dentro del mismo evento
            // donde item debera ser un tag que diferencie a las monedas del resto 
        }

    }

}
