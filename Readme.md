# Контрольная работа. Выбор специализации.

## Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

### Описание решения
1. Сначала делается перебор значений из исходного массива.
2. Затем проверяется каждое значение из массива на соответствие условию задачи: _длина строки не должна быть больше 3_.
3. Если строка массива удовлетворяет условию, это значение перекладывается в новый массив.
4. После, повторяются пункты **2** и **3**.
5. В конце цикла возвращается новый заполненный массив, со строками менее или равные 3 символам.

## Блок-схема
![Alt text](diagramm/%D0%91%D0%BB%D0%BE%D0%BA-%D1%81%D1%85%D0%B5%D0%BC%D0%B0%20%D1%80%D0%B5%D1%88%D0%B5%D0%BD%D0%B8%D1%8F.png)

## Описание программы
Для запуска программы необходимо перейти в папку **control_work_task**, вызвать терминал, затем, запустить программу командой:
*dotnet run*

Далее в терминал нужно ввести строки через пробел, например:
__hello 2 world computer science 23 col world__

В результате программа выведет на экран массив с введенными строками, а затем и результат решения задачи:
__[hello, 2, world, computer, science, 23, col, world] -> [2, 23, col]__

### ЗАДАЧА РЕШЕНА ###