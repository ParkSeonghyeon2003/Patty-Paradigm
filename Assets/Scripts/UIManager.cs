using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text daysText;

    void LateUpdate()
    {
        // 추후 날짜가 지날 때 마다 호출하는 것으로 수정할 것.
        DisplayDays();
    }

    private void DisplayDays()
    {
        daysText.text = string.Format("{0:F0}일차", GameManager.days);
    }
}