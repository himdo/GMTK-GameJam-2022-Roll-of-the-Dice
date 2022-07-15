using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceHelper : MonoBehaviour
{
    [SerializeField]
    private int EndingNumber;
    [SerializeField]
    private bool FinishedRotating = true;

    float TimeToRotate = 2f;
    float Timer = 0f;

    public void SetEndingNumber(int number)
    {
        EndingNumber = number;
        FinishedRotating = false;
    }

    public int GetEndingNumber()
    {
        return EndingNumber;
    }

    public void RotateToNumber(int number)
    {
        SetEndingNumber(number);
    }

    private void FixedUpdate()
    {
        if (!FinishedRotating)
        {
            Timer += Time.deltaTime;

            if (Timer < TimeToRotate)
            {
                transform.Rotate(new Vector3(30f, 30f, 30f), Space.Self);
                Debug.Log(Timer);
            } else
            {
                int smooth = 10000;
                Quaternion targetRotation = DiceQuaternionFromNumber(EndingNumber);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, smooth * Time.deltaTime);
                if (transform.rotation == targetRotation)
                {
                    FinishedRotating = true;
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Quaternion DiceQuaternionFromNumber(int number)
    {
        Quaternion rotation = new Quaternion();

        switch (number)
        {
            case 1:
                rotation.Set(0, 0, 0, 1);
                break;
            case 2:
                rotation.Set(0.70711f, 0, 0, 0.70711f);
                break;
            case 3:
                rotation.Set(0, 0.70711f, 0, -0.70711f);
                break;
            case 4:
                rotation.Set(0, 0.70711f, 0, 0.70711f);
                break;
            case 5:
                rotation.Set(0.70711f, 0, 0, -0.70711f);
                break;
            case 6:
                rotation.Set(0.70711f, -0.70711f, 0, 0);
                break;
        }

        return rotation;
    }

    public Vector2 DiceRotationFromNumber(int number)
    {
        Vector2 rotation = new Vector2();

        switch (number)
        {
            case 1:
                rotation.x = 0;
                rotation.y = 0;
                break;
            case 2:
                rotation.x = 90;
                rotation.y = 0;
                break;
            case 3:
                rotation.x = 0;
                rotation.y = 270;
                break;
            case 4:
                rotation.x = 0;
                rotation.y = 90;
                break;
            case 5:
                rotation.x = 270;
                rotation.y = 0;
                break;
            case 6:
                rotation.x = 180;
                rotation.y = 0;
                break;
        }

        return rotation;
    }
}
