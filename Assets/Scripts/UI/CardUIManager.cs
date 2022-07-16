using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardUIManager : MonoBehaviour
{
    private Cards LastCard;
    public Cards CardObject;
    public GameObject Name;
    public GameObject Sprite;
    public GameObject Description;
    public GameObject CardType;
    public GameObject DamageText;
    public List<GameObject> DiceDisplay;

    public Sprite DefenseType;
    public Sprite AttackType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private string GetCardText(Cards card, int DiceNumber)
    {
        string text = "";
        CardDice cd = card.NumberRequired[DiceNumber];
        switch (cd.Mode)
        {
            case DiceModesEnum.Exact:
                text += cd.Number.ToString();
                break;
            case DiceModesEnum.LessOrEqual:
                text += cd.Number.ToString() + "-";
                break;
            case DiceModesEnum.MoreOrEqual:
                text += cd.Number.ToString() + "+";
                break;
        }
        return text;
    }

    // Update is called once per frame
    void Update()
    {
        if (CardObject != LastCard)
        {
            Name.GetComponent<TextMeshProUGUI>().text = CardObject.Name;
            Description.GetComponent<TextMeshProUGUI>().text = CardObject.Description;
            for (int i = 0; i < DiceDisplay.Count; i++)
            {
                DiceDisplay[i].SetActive(false);
            }
            switch (CardObject.NumberOfDiceRequired)
            {
                case 3:
                    DiceDisplay[0].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetCardText(CardObject, 0);
                    DiceDisplay[0].SetActive(true);
                    DiceDisplay[1].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetCardText(CardObject, 1);
                    DiceDisplay[1].SetActive(true);
                    DiceDisplay[2].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetCardText(CardObject, 2);
                    DiceDisplay[2].SetActive(true);
                    break;
                case 2:
                    DiceDisplay[0].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetCardText(CardObject, 0);
                    DiceDisplay[0].SetActive(true);
                    DiceDisplay[2].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetCardText(CardObject, 1);
                    DiceDisplay[2].SetActive(true);
                    break;
                case 1:
                    DiceDisplay[1].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetCardText(CardObject, 0);
                    DiceDisplay[1].SetActive(true);
                    break;
            }
            if (CardObject._DamageType == DamageType.Damage)
            {
                CardType.GetComponent<Image>().sprite = AttackType;
            } else if (CardObject._DamageType == DamageType.Defense)
            {
                CardType.GetComponent<Image>().sprite = DefenseType;
            } else
            {
                Debug.LogError("Card type unknown Please fix");
            }
            DamageText.GetComponent<TextMeshProUGUI>().text = CardObject.Damage.ToString();
            LastCard = CardObject;
        }
    }
}
