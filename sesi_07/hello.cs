using System;
using System.Windows.Forms;

public class MyHelloWorld : Form
{
    public static void Main() {
        Application.Run(new MyHelloWorld());
    }
    public MyHelloWorld() {
        Text = "Hi!!!";
    }
}