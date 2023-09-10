using UnityEngine;
using static DateTimeUtil;

public class Sample : MonoBehaviour
{
    private void OnGUI()
    {
        GUILayout.Label(DateTimeNowInMS);
        GUILayout.Label(DateTimeNowInHM);
        GUILayout.Label(DateTimeNowInHMS);
        GUILayout.Label(DateTimeNowInHMSF);
        GUILayout.Label(DateTimeNowInYMDHMS);
        GUILayout.Label(DateTimeNowInYMDHMSF);
    }
}