using UnityEngine;
using System;
using TMPro;

public class Date_Time : MonoBehaviour
{
    public TextMeshProUGUI dateText;
    public TextMeshProUGUI timeText;

    void Start()
    {
        InvokeRepeating(nameof(UpdateDateTime), 0f, 1f);
    }

    void UpdateDateTime()
    {
        DateTime now = DateTime.Now;
        dateText.text = now.ToString("dd MMM yyyy");
        timeText.text = now.ToString("HH:mm:ss");
    }
}

