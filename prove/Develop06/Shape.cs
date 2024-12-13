using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

public class Shape{
    private string _color;

    public Shape(string color){
        _color = color;
    }

    public string GetColor(){
        return _color;
    }

    public void SetColor(string color){
        _color = color;
    }
    public virtual double GetArea(){
        return 1;
    }
}