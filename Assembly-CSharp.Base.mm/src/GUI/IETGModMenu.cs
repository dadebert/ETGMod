﻿#pragma warning disable 0626
#pragma warning disable 0649

using UnityEngine;
using System.Collections.Generic;
using System;

public interface IETGModMenu {

    void Start();
    void Update();
    void OnGUI();
    void OnDestroy();

}

public class ETGModNullMenu : IETGModMenu {
    public void Start() { }
    public void Update() { }
    public void OnGUI() { }
    public void OnDestroy() { }
}
