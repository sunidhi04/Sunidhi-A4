using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class CoinCounterUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI current;
    [SerializeField] private TextMeshProUGUI toUpdate;
    [SerializeField] private Transform coinTextContainer;
    [SerializeField] private float duration;

    private float containerInitPosition;
    private float moveAmount;

    private void Start()
    {
        Canvas.ForceUpdateCanvases();
        current.SetText("0");
        toUpdate.SetText("0");
        containerInitPosition = coinTextContainer.localPosition.y;
        moveAmount = current.rectTransform.rect.height;
    }
    public void UpdateScore(int score)
    {
        toUpdate.SetText($"{score}");
        coinTextContainer.DOLocalMoveY(containerInitPosition + moveAmount, duration);
    }
}