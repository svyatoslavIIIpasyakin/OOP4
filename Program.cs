using System;

public class MyClass
{
    // Короткая запись свойства
    public string ShortProperty { get; set; }

    // Полная запись свойства с геттером и сеттером
    private string _fullProperty;
    public string FullProperty
    {
        get { return _fullProperty; }
        set { _fullProperty = value; }
    }

    // Полная запись свойства int с геттером и сеттером,
    // недопустимые отрицательные значения
    private int _integerProperty;
    public int IntegerProperty
    {
        get { return _integerProperty; }
        set
        {
            if (value >= 0)
            {
                _integerProperty = value;
            }
            else
            {
                Console.WriteLine("Недопустимое значение для IntegerProperty. Значение должно быть неотрицательным.");
            }
        }
    }

    // Вычисляемое свойство типа bool
    public bool IsIntegerPropertyLessThan25
    {
        get { return IntegerProperty < 25; }
    }

    // Перегружаемый метод GetInfo()
    public string GetInfo()
    {
        return $"ShortProperty: {ShortProperty}, FullProperty: {FullProperty}, IntegerProperty: {IntegerProperty}, IsIntegerPropertyLessThan25: {IsIntegerPropertyLessThan25}";
    }

    // Перегружаемый метод GetInfo(bool includeIntProperty)
    public string GetInfo(bool includeIntProperty)
    {
        if (includeIntProperty)
        {
            return $"ShortProperty: {ShortProperty}, FullProperty: {FullProperty}, IntegerProperty: {IntegerProperty}, IsIntegerPropertyLessThan25: {IsIntegerPropertyLessThan25}";
        }
        else
        {
            return $"ShortProperty: {ShortProperty}, FullProperty: {FullProperty}, IsIntegerPropertyLessThan25: {IsIntegerPropertyLessThan25}";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        myObject.ShortProperty = "Short";
        myObject.FullProperty = "Full";
        myObject.IntegerProperty = 20;

        Console.WriteLine(myObject.GetInfo()); // Вывод информации о свойствах объекта
        Console.WriteLine(myObject.GetInfo(includeIntProperty: false)); // Вывод информации без включения свойства IntegerProperty
    }
}
