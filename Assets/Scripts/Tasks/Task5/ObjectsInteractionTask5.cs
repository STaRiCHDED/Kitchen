using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] 
    private Shelf _firstShelf;
    [SerializeField] 
    private Shelf _secondShelf;
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    private void Start()
    {
        _firstShelf.ItemSpawned += CheckFirstShelf;
        _secondShelf.ItemSpawned += CheckSecondShelf;
    }
    
    private void OnDestroy()
    {
        _firstShelf.ItemSpawned -= CheckFirstShelf;
        _secondShelf.ItemSpawned -= CheckSecondShelf;
    }
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    private void CheckFirstShelf()
    {
        if (_firstShelf.ItemsCount > 3)
        {
            _firstShelf.Fall();
        }
    }
    private void CheckSecondShelf()
    {
        if (_secondShelf.ItemsCount > 3)
        {
            _secondShelf.Fall();
        }
    }
    // TODO: Логика должна работать для обоих полок сцены
}