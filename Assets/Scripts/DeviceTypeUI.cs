using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceTypeUI : MonoBehaviour {
    void Start() {
        string deviceName = SystemInfo.graphicsDeviceName;
        string deviceTypeName = SystemInfo.graphicsDeviceType.ToString();
        GetComponent<Text>().text = deviceName + "\n" + deviceTypeName;
    }
}
