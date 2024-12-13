using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] UIManager _uiManager;
    [SerializeField] UIDialogShop _uiDialogShop;
    [SerializeField] private Tower _tower;
    [SerializeField] private GameObject _coin;

    [SerializeField] private GameObject _itemAxe;
    [SerializeField] private GameObject _itemMace;
    [SerializeField] private GameObject _itemSpear;
    [SerializeField] private GameObject _itemWand;
    
    private int _dropItemAxe = 1;
    private int _dropItemMace = 2;
    private int _dropItemSpear = 3;
    private int _dropItemWand = 4;

    private void Update()
    {
        transform.position += new Vector3(4, 0, 0) * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            _tower.RemoveEnemyFromList(this);
            Destroy(gameObject);

            Vector3 dropPosition = transform.position + new Vector3(Random.Range(-0.5f, 0.5f), -0.5f, Random.Range(-0.5f, 0.5f));
            for(int i = 0; i < 10; i++)
            {
                var newCoin = Instantiate(_coin, dropPosition, Quaternion.identity);
                Destroy(newCoin, 3f);
                _uiManager.Coin++;
            }

            int randomValue = Random.Range(1, 10);
            if(randomValue <= _dropItemAxe)
            {
                var newAxe = Instantiate(_itemAxe, dropPosition, Quaternion.identity);
                Destroy(newAxe, 3f);
                _uiDialogShop.CountAxe++;
            }
            if (randomValue <= _dropItemMace)
            {
                var newMace = Instantiate(_itemMace, dropPosition, Quaternion.identity);
                Destroy(newMace, 3f);
                _uiDialogShop.CountMace++;
            }
            if (randomValue <= _dropItemSpear)
            {
                var newSpear = Instantiate(_itemSpear, dropPosition, Quaternion.identity);
                Destroy(newSpear, 3f);
                _uiDialogShop.CountSpear++;
            }
            if (randomValue <= _dropItemWand)
            {
                var newWand = Instantiate(_itemWand, dropPosition, Quaternion.identity);
                Destroy(newWand, 3f);
                _uiDialogShop.CountWand++;
            }
        }
    }
}
