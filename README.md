#В данном репозитории содержится решение задачи для NedraStream от Самсонова Льва
<br />https://spb.hh.ru/resume/1e6bd75dff072a4a800039ed1f62306d6a7966

<br />Для решения задачи лучше всего подходит бинарное поисковое дерево которое реализует два метода Add и GetMaxSum
<br />Метод Add добавляет число в дерево
<br />Метод GetMaxSum возращает максимальную сумму которую можно получить от начала дерева на всем пути
<br />Как основа для алгоритма использовался "Поиск в глубину" 

<br />Был создан интерфейс ITree и класс Tree реализующий данный интерфейс
<br />Интерфейс ITree имеет три метода Add, HasValue, GetMaxSum
<br />Также было написанно несколько простых Unit тестов

<br />Пример
<br />       100 
<br />   50       150
<br /> 10  60   110  150
<br />       105 130
<br />Ответ: 490
