using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float gameTime;

    void Update()
    {
        gameTime += Time.deltaTime;
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.FloorToInt(gameTime).ToString() + "s";
        }
    }
}
