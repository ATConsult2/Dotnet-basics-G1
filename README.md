# Dotnet-basics-G1
Dot net intro (C#)  - training repository.
## ДЗ 1 - на выходные

- Создайте решение Visual Stidio.
- Добавьте в решение два консольных проекта.
Первый проект назовите TestUtils (в нём должны быть метод Main). Второй проект назовите Utils, единственный класс
этого проекта назовите также.
- В классе Utils создайте открытый статический метод 
echo с параметрами string message, string S и int N.
Метод должен выводить на консоль центрированные заголовки общей длиной N знаков,
где в центре размещается сообщение, а по обе стороны от него - символы заполнители.
Например, для message="CLASS", S="-" и N=31 
метод должен выводить строку заголовок вида:

----------- CLASS ------------
- Далее нужно подключить проект Utils к первому проекту TestUtils и протестировать
результат работы метода echo.

