В данном репозитории содержится решение задачи для NedraStream от Самсонова Льва
https://spb.hh.ru/resume/1e6bd75dff072a4a800039ed1f62306d6a7966

Для решения задачи лучше всего подходит бинарное поисковое дерево которое реализует два метода Add и GetMaxSum
Метод Add добавляет число в дерево
Метод GetMaxSum возращает максимальную сумму которую можно получить от начала дерева на всем пути
Как основа для алгоритма использовался "Поиск в глубину" 

Был создан интерфейс ITree и класс Tree реализующий данный интерфейс
Интерфейс ITree имеет три метода Add, HasValue, GetMaxSum
Также было написанно несколько простых Unit тестов

Пример
      100 
  50       150
10  60   110  150
       105 130
Ответ: 490
