using UnityEngine;
using UnityEngine.UI;

public class CellView : MonoBehaviour
{
    [SerializeField] private Image discImage;
    [SerializeField] private Button button;
    [SerializeField] private Sprite blackSprite;
    [SerializeField] private Sprite whiteSprite;


    private int x;
    private int y;

    public void Initialize(int x, int y)
    {
        this.x = x;
        this.y = y;
        discImage.enabled = false;
    }

    public void SetDisc(Disc disc)
    {
        switch (disc)
        {
            case Disc.Empty:
                discImage.enabled = false;
                break;

            case Disc.Black:
                discImage.enabled = true;
                discImage.sprite = blackSprite;
                break;

            case Disc.White:
                discImage.enabled = true;
                discImage.sprite = whiteSprite;
                break;
        }
    }
}
