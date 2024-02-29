# Контрольная работа
### <u>**Задача:**</u> написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### <u>**Решение:**</u> пользователь вводит массив строк, который сохраняется в переменную; если массив не был введён, используется массив по умолчанию; далее идёт создание нового массива: первым этапом определется размер массива; далее заполняется новый массив, при этом каждая строка проверяется на соответствие требованиям - размер строки должен быть меньше либо равен 3; после заполнения нового массива, используется метод, который выводит его на экран: каждый элемент выводится через запятную; если новый массив не содержит строк, соответствующих требованиям программы, выводится пустой массив.