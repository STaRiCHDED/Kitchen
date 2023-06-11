using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
    [SerializeField] 
    private Transform _waffleRoot;
    [SerializeField] 
    private Waffle _wafflePrefab;
    [SerializeField] 
    private Toaster _toaster;
    private void Start()
    {
        _toaster.TimerIsUp += CreateWaffle;
    }

    private void CreateWaffle()
    {
        var waffle = Instantiate(_wafflePrefab);
        waffle.transform.position = _waffleRoot.position;
    }
    private void OnDestroy()
    {
        _toaster.TimerIsUp -= CreateWaffle;
    }
}