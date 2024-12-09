using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public UIDialogShop DialogShop;
    public UIDialogWarehouse DialogWarehouse;

    [SerializeField] private TextMeshProUGUI _coin;
    [SerializeField] private Button _btnShop;
    [SerializeField] private Button _btnWarehouse;
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _warehouse;

    public int Coin;

    private void Start()
    {
        _btnShop.onClick.AddListener(() => ShowHide(_shop));
        _btnWarehouse.onClick.AddListener(() => ShowHide(_warehouse));
    }
    private void Update()
    {
        _coin.text = "Coin: " + Coin.ToString();
    }
    private void ShowHide(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
}
