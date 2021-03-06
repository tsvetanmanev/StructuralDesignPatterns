# StructuralDesignPatterns - Струтурни шаблони за дизайн

## Фасада
![Facade pattern](/FacadeExample/CodeMap-Facade.JPG?raw=truea)

Фасадата ни дава опростен интерфейс (публични методи). Зад тези публични методи може да се крие много сложен код.
Това е лесен начин за използване на сложно API. Постига се разкачване на кода. 
Следва принципа "Колкото по-малко знаеш, толкова по-добре".

Примери за фасада: AJAX заявките в jQuery, XmlSerializer in JSON.Net, Скриване на стари АПИ-та зад модерен интерфейс

## Декоратор
![Decorator pattern](/DecoratorExample/CodeMap-Decorator.JPG)

Декоратора ни дава възможност да добавяме фунцкионалност към даден обект Run-Time. 
Допълнителни методи и фунцкионалности се добавят докато работи приложението.
Това решава проблема с твърде многото наследници, като спазваме Open-Close принципът.

Може да се използва за екстендваме стари системи. Използва се за добавяне на функционалност към UI контроли. 
В .NET: CryptoStream, GZipStream декорират Stream
