using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] _lamps;
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    private void Start()
    {
        _lamps = FindObjectsOfType<Lamp>();
    }
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var lamp in _lamps)
            {
               lamp.Interact();     
            }
        }
    }
}