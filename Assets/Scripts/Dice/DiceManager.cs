using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public GameObject DicePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject dice = SpawnDice();
            dice.GetComponent<DiceHelper>().SetEndingNumber(RandomNumberGenerator.RoleDice(6));
        }
    }
    

    public GameObject SpawnDice()
    {
        GameObject dice = GameObject.Instantiate(DicePrefab);
        return dice;
    }

    public void DeleteDice(GameObject dice)
    {
        Destroy(dice);
    }
}
