using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIDialogWarehouse : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;

    [SerializeField] private Button _btnAxe;
    [SerializeField] private Button _btnMace;
    [SerializeField] private Button _btnSpear;
    [SerializeField] private Button _btnWand;

    [SerializeField] private TextMeshProUGUI _txtCountAxe;
    [SerializeField] private TextMeshProUGUI _txtCountMace;
    [SerializeField] private TextMeshProUGUI _txtCountSpear;
    [SerializeField] private TextMeshProUGUI _txtCountWand;

    public int CountAxe = 0;
    public int CountMace = 0;
    public int CountSpear = 0;
    public int CountWand = 0;

    private void Start()
    {
        _btnAxe.onClick.AddListener(() => BtnUseItems(ref _uiManager.DialogShop.CountAxe));
        _btnMace.onClick.AddListener(() => BtnUseItems(ref _uiManager.DialogShop.CountMace));
        _btnSpear.onClick.AddListener(() => BtnUseItems(ref _uiManager.DialogShop.CountSpear));
        _btnWand.onClick.AddListener(() => BtnUseItems(ref _uiManager.DialogShop.CountWand));
    }
    private void Update()
    {
        _txtCountAxe.text = "Count: " + _uiManager.DialogShop.CountAxe.ToString();
        _txtCountMace.text = "Count: " + _uiManager.DialogShop.CountMace.ToString();
        _txtCountSpear.text = "Count: " + _uiManager.DialogShop.CountSpear.ToString();
        _txtCountWand.text = "Count: " + _uiManager.DialogShop.CountWand.ToString();
    }
    private void BtnUseItems(ref int count)
    {
        if (count <= 0) return;
        count--;
    }
}
