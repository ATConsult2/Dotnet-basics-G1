# Dotnet-basics-G1
Dot net intro (C#)  - training repository.
## ДЗ 1 - на выходные

- Создайте решение Visual Studio.
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

## ДЗ 2 - выполнить к последнему занятию
- Создать класс Library. Класс должен реализовать шаблон Singleton – можно создать только один экземпляр этого класса.
- Создать тип Book c следующими свойствами:  Title, Author, Year, Id. Перекрыть в Book метод toString. Использовать конструктор.
- В класс Library добавить коллекцию типов Book в виде свойства Books. Предусмотреть генерацию "уникального" Id при добавлении книги в библиотеку.
- Реализовать для типа Library интерфейс:

```cs
  interface ILibrary
    {
        bool addBook(Book book);
        Book getBook(int Id);
        IEnumerable<Book> getAllBooks();
        IEnumerable<Book> getBooksOfAuthor(string Author);
    }
```
Другие операции с книгами не допускаются.
- Подумать, какие ещё типы данных необходимы для работы библиотеки.

## Дополнительные ссылки и материалы к курсу:
- [MS reference src](https://referencesource.microsoft.com/)
- [Книги](https://disk.yandex.ru/d/06YPhzW1ttkABA)
