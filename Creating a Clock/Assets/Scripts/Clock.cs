using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update() {
        TimeSpan now = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)now.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)now.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)now.TotalSeconds);
    }
}

