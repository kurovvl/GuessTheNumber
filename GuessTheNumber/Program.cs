// See https://aka.ms/new-console-template for more information
using GuessTheNumber.Classes;
using GuessTheNumber.Interfaces;

// Обработчик генерации чисел
IGenerator numberGenerator = new AdvancedNumberGenerator();

// Обработчик пользовательского ввода
IUserInput userInput = new AdvancedUserInput();

// Настройки
GameSettings gameSettings = new GameSettings
{
    Min = -100,
    Max = 100,
    Attempts = 10
};

// Создаем новую игру с заданными настройками и зависимостями
Game game = new Game(numberGenerator, userInput, gameSettings);

game.Play(); // Запускаем игру



/*
 SOLID:
    Single Responsibility Principle - каждый класс выполняет только одну задачу.
    Open/Close Principle - базовые классы открыты для расширения (через наследование и переопределение методов), но закрыты для модификации
    Liskov Substitution Principle - объекты классов могут заменить объекты базовых классов без изменения корректности программы.
    Interface Segregation Principle - интерфейсы малы и специфичны, они не заставляют классы реализовывать методы, которые они не используют.
    Dependency Inversion Principle - класс зависит от абстракций (интерфейсов), а не от конкретных классов. Это позволяет легко заменить одну реализацию на другую без изменения класса.
*/
