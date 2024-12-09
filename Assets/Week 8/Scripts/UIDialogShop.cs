using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIDialogShop : MonoBehaviour
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

    [SerializeField] private TextMeshProUGUI _txtPriceAxe;
    [SerializeField] private TextMeshProUGUI _txtPriceMace;
    [SerializeField] private TextMeshProUGUI _txtPriceSpear;
    [SerializeField] private TextMeshProUGUI _txtPriceWand;

    [SerializeField] private int PriceAxe = 5;
    [SerializeField] private int PriceMace = 7;
    [SerializeField] private int PriceSpear = 2;
    [SerializeField] private int PriceWand = 8;

    private void Start()
    {
        _txtPriceAxe.text = "Price: " + PriceAxe.ToString();
        _txtPriceMace.text = "Price: " + PriceMace.ToString();
        _txtPriceSpear.text = "Price: " + PriceSpear.ToString();
        _txtPriceWand.text = "Price: " + PriceWand.ToString();

        _btnAxe.onClick.AddListener(() => BtnBuyItems(PriceAxe, ref CountAxe));
        _btnMace.onClick.AddListener(() => BtnBuyItems(PriceMace, ref CountMace));
        _btnSpear.onClick.AddListener(() => BtnBuyItems(PriceSpear, ref CountSpear));
        _btnWand.onClick.AddListener(() => BtnBuyItems(PriceWand, ref CountWand));
    }
    private void Update()
    {
        _txtCountAxe.text = "Count: " + CountAxe.ToString();
        _txtCountMace.text = "Count: " + CountMace.ToString();
        _txtCountSpear.text = "Count: " + CountSpear.ToString();
        _txtCountWand.text = "Count: " + CountWand.ToString();
    }
    private void BtnBuyItems(int price,ref int count)
    {
        if (_uiManager.Coin < price) return;
        _uiManager.Coin -= price;
        count++;
    }
}
