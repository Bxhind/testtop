// Дописать нереализованные, но созданые функции, обработать возможные ошибки
// Написать юнит тесты для всех функций для разных сценариев их использования
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;

    // Добавить умножение
    public int Multiply(int a, int b)
    {
        throw new NotImplementedException("Multiply not implemented yet!");
    }

    // Добавить деление
    public double Divide(int a, int b)
    {
        throw new NotImplementedException("Divide not implemented yet!");
    }

    // Добавить возведение в степень
    public double Power(double a, double b)
    {
        throw new NotImplementedException("Power not implemented yet!");
    }
}