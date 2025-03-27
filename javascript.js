// Дописать нереализованные, но созданые функции, обработать возможные ошибки
// Написать юнит тесты для всех функций для разных сценариев их использования
class Calculator {
    add(a, b) {
        return a + b;
    }

    subtract(a, b) {
        return a - b;
    }

    // Добавить умножение
    multiply(a, b) {
        throw new Error("Multiply not implemented yet!");
    }

    // Добавить деление
    divide(a, b) {
        throw new Error("Divide not implemented yet!");
    }

    // Добавить возведение в степень
    power(a, b) {
        throw new Error("Power not implemented yet!");
    }
}

module.exports = Calculator;