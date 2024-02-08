using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject contentUIImage;

    private void OnEnable()
    {
        Content.OnContentEnter += ShowContentUI;
    }

    private void OnDisable()
    {
        Content.OnContentEnter -= ShowContentUI;
    }

    private void ShowContentUI()
    {
        contentUIImage.SetActive(true);
    }
}