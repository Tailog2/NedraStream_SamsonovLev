// See https://aka.ms/new-console-template for more information
using NedraStreamSamsonovLev;
Console.WriteLine("This is a task's sulution for NedraStream from Samsonov Lev");


// Для решения задачи лучше всего подходит бинарное поисковое дерево которое реализует два метода Add и GetMaxSum
// Метод Add добавляет число в дерево
// Метод GetMaxSum возращает максимальную сумму которую можно получить от начала дерева на всем пути
// Как основа для алгоритма использовался "Поиск в глубину" 

// Был создан интерфейс ITree и класс Tree реализующий данный интерфейс
// Интерфейс ITree имеет три метода Add, HasValue, GetMaxSum
// Также было написанно несколько простых Unit тестов

// Пример
//       100 
//   50       150
// 10  60   110  150
//        105 130
// Ответ: 490

Tree tree = new Tree();
tree.Add(100);
tree.Add(50);
tree.Add(150);
tree.Add(10);
tree.Add(60);
tree.Add(110);
tree.Add(150);
tree.Add(105);
tree.Add(130);

Console.WriteLine(tree.GetMaxSum());