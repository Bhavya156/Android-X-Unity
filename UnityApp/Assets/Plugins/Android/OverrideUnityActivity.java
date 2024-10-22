package com.unity3d.player;
import android.os.Bundle;

public abstract class OverrideUnityActivity extends UnityPlayerActivity {
    public static OverrideUnityActivity intance = null;

    abstract public void onGameQuit();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        intance = this;
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        intance = null;
    }
}