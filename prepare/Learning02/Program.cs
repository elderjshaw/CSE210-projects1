/*
Rectangle Program w/ Inheritance
*/

public class Rectangle
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length > 0 ? length : 0;
        _width = width > 0 ? width : 0;
    }

    public double Area()
    {
        return _length * _width;
    }

    public double Perimeter()
    {
        return 2 * (_length + _width);
    }


}