using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)
    [SerializeField] 
    private Transform _lampRoot;
    [SerializeField] 
    private GameObject _lampPrefab;

    private void Awake()
    {
        var lamp = Instantiate(_lampPrefab);
        lamp.transform.position = _lampRoot.position;
    }
}