using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text daysText;

    void LateUpdate()
    {
        // ���� ��¥�� ���� �� ���� ȣ���ϴ� ������ ������ ��.
        DisplayDays();
    }

    private void DisplayDays()
    {
        daysText.text = string.Format("{0:F0}����", GameManager.days);
    }
}