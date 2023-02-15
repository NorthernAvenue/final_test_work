# Первая четверть. Итоговая проверочная работа. :floppy_disk:

## Задачи: :computer:


:red_circle:***1. Создать [репозиторий](https://github.com/NorthernAvenue/final_test_work) на GitHub***

:red_circle:***2. Написать [программу](/final_task/Program.cs), которая из имеющегося массива строк формирует массив строк, длина строк которого меньше, либо равна 3 символа***

:red_circle:***3. Нарисовать [блок-схему](блок-схема) алгоритма исполняющего поставленную задачу***

:red_circle:***4. Дополнить репозиторий оформленным текстовым [описанием](описание) решения***

***
### ![Задачи](/img/final_task.png)
***

Основная логика программы реализована в трех функциях:

1. GetOriginalArraySize() запрашивает у пользователя размер массива, проверяет, что введено целое число, и возвращает это число в качестве результата.

2. FillOriginalArray(string[] array) заполняет переданный массив строковыми значениями, запрашивая их у пользователя. Для этого она запускает цикл, в котором на каждой итерации выводится приглашение для ввода элемента массива под определенным индексом, и пользователь вводит строковое значение, которое сохраняется в соответствующем элементе массива.

3. ModifiedArray(string[] array) создает и возвращает новый массив, содержащий только те элементы переданного массива, длина которых меньше или равна 3 символам. Для этого она проходится по всем элементам массива и подсчитывает количество элементов, удовлетворяющих заданному условию. Затем она создает новый массив нужной длины и заполняет его элементами, удовлетворяющими условию.
***
### Программа начинается с запроса размера исходного массива, который сохраняется в переменной size. Затем создается массив originalArray нужного размера, заполняется с помощью функции FillOriginalArray(), и выводится на консоль с помощью функции PrintArray(). Затем с помощью функции ModifiedArray() создается новый массив, содержащий только нужные элементы исходного массива, и он также выводится на консоль с помощью функции PrintArray().

##### (P.S.Проверку на пустой массив опустил)









