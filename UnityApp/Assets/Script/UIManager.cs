using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private AndroidJavaObject _currentActivity;

    void Start() {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        _currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    }

    public void OnApplicationGoToAndroidButton() {
        _currentActivity.Call("onGameQuit");
    }
}
