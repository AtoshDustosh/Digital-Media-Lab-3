using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameObject2D
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public GameObject2D(string name)
    {
        Name = name;
    }
}

class Rectangle : GameObject2D
{
    private int width;
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }
    private int height;
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public Rectangle(string name, int width, int height) : base(name)
    {
        Width = width;
        Height = height;
    }
}


public class CSharpDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // value_DataType();
        reference_DataType();
        // createGameObject2D();
        // createRectangle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void value_DataType()
    {
        // 'transform.position' gives the position of the sphere
        Debug.Log("x = " + transform.position.x + " y = "
            + transform.position.y + " z = " + transform.position.z);

        Vector3 v1 = transform.position;
        v1.x += 1f;
        v1.y += 1f;
        v1.z += 1f;

        Debug.Log("x = " + transform.position.x + " y = "
            + transform.position.y + " z = " + transform.position.z);
    }

    void reference_DataType()
    {
        // 'transform.position' gives the position of the sphere
        Debug.Log("x = " + transform.position.x + " y = "
            + transform.position.y + " z = " + transform.position.z);

        Transform trans = transform;

        // note that, here we change the 'trans.position' not 'transform.position'
        trans.position = trans.position + new Vector3(1f, 1f, 1f);

        Debug.Log("x = " + transform.position.x + " y = "
            + transform.position.y + " z = " + transform.position.z);

        Rectangle rect1 = new Rectangle("rect1", 3, 4);
        Rectangle rect2 = rect1;

        Debug.Log("name: " + rect1.Name + ", width: " + rect1.Width
            + ", height: " + rect1.Height);

        rect2.Name = "rect2";
        rect2.Width = 6;
        rect2.Height = 8;

        Debug.Log("name: " + rect1.Name + ", width: " + rect1.Width
            + ", height: " + rect1.Height);



    }

    void createGameObject2D()
    {
        // create 3 instances of the class 'GameObject2D'
        // and their names are Peter, David and John.
        GameObject2D peter = new GameObject2D("Peter");
        GameObject2D david = new GameObject2D("David");
        GameObject2D john = new GameObject2D("John");

        // define a List (C# data structure, as introduced in the lecture)
        // which holds 3 instances.
        // note that, if 'List' is not recognized by Monodeveloper, you need to
        // include another namespace, i.e. 'using ...'
        List<GameObject2D> goList = new List<GameObject2D>();
        goList.Add(peter);
        goList.Add(david);
        goList.Add(john);

        // using the loop structure, foreach, to print names of the 3 instances
        // created earlier. 
        foreach(GameObject2D go in goList)
        {
            Debug.Log("name: " + go.Name);
        }
    }

    void createRectangle()
    {
        Rectangle rect1 = new Rectangle("rect1", 3, 4);
        Rectangle rect2 = new Rectangle("rect2", 6, 8);
        Rectangle rect3 = new Rectangle("rect3", 9, 12);

        ArrayList rectList = new ArrayList();

        rectList.Add(rect1);
        rectList.Add(rect2);
        rectList.Add(rect3);

        foreach (Rectangle rect in rectList)
        {
            Debug.Log("name: " + rect.Name + ", width: " + rect.Width
                + ", height: " + rect.Height);
        }
    }
}
