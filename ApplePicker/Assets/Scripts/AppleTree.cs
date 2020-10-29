using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //елемент, який можна налаштовувати в інспекторі для обєкта
    public GameObject applePrefab; //це має бути яблуко
    /// <summary>
    /// Швидкість переміщення яблуні
    /// </summary>
    public float speed = 1f;

    //Межі я яких буде рухатися яблуня
    public float leftAndRightEdge = 10f;

    //Імовірність зміни напряку руху яблуні
    public float chanceToChageDirections = 0.1f;

    //Частота скинда яблук із яблуні
    public float secondsBerweenAppleDrops = 1f; //буде скидати яблука раз у секунду

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position; //встановлюємо позицію відносно дерева
        Invoke("DropApple", secondsBerweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; //поточна позиція
        pos.x += speed * Time.deltaTime; //Зміна позиції відносно часу, який пройшов з моменту відображення попереднього кадра
        transform.position = pos; //змінюємо позицію яблуні

        //Зміна пряму руху
        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Зміна руху вправо
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Почали рух в ліво
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChageDirections)
        {
            speed *= -1;
        }
    }
}
