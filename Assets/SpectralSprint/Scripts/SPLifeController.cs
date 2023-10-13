using MoreMountains.CorgiEngine;
using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPLifeController : MonoBehaviour
{
    public Sprite HeartFull;
    public Sprite HeartEmpty;

    [SerializeField]
    private int Health;
    [SerializeField]
    private int NumOfHearts;

    [Tooltip("the size of the heart to display")]
    public Vector2 HeartSize = new Vector2(5, 5);
    [Tooltip("La cantidad maxima de corazones que se crearan")]
    public int MaxHearts;

    protected List<Image> Hearts;

    void Start()
    {
        Health = GameManager.Instance.CurrentLives;
        NumOfHearts = GameManager.Instance.MaximumLives;
        CreateHearts();
        UpdateHearts();
    }

    void Update()
    {
        UpdateHearts();
    }
    /// <summary>
    /// genera la instancia de corazones teniendo en cuenta la cantidad dada.
    /// </summary>
    protected virtual void CreateHearts()
    {
        Hearts = new List<Image>();

        foreach(Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < MaxHearts; i++)
        {
            GameObject heart = new GameObject();
            heart.transform.SetParent(this.transform);
            heart.name = "Heart" + i;

            Image heartImage = heart.AddComponent<Image>();
            heartImage.sprite = HeartFull;

            heart.MMFGetComponentNoAlloc<RectTransform>().localScale = Vector3.one;
            heart.MMFGetComponentNoAlloc<RectTransform>().sizeDelta = HeartSize;

            Hearts.Add(heartImage);
        }
    }

    /// <summary>
    /// Actualiza los Cora zones.
    /// </summary>
    protected virtual void UpdateHearts()
    {
        Debug.Log("UpdateHeart");
        Health = GameManager.Instance.CurrentLives;
        for (int i = 0; i < MaxHearts; i++)
        {
            if ((i < NumOfHearts) && (Hearts[i].sprite != HeartEmpty))
            {
                Hearts[i].sprite = HeartEmpty;
            }

            if ((i < Health) && (Hearts[i].sprite != HeartFull))
            {
                Hearts[i].sprite = HeartFull;
            }

            if ((i < NumOfHearts) && (Hearts[i].enabled == false))
            {
                Hearts[i].enabled = true;
            }

            if ((i >= NumOfHearts) && (Hearts[i].enabled != false))
            {
                Hearts[i].enabled = false;
            }
        }
    }
}
