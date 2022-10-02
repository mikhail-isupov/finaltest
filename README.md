# Описание решения

1. Метод получает аргументы - входной массив строк *inputArray* и максимальную длину строки *maxLength*.

2. Создается и обнуляется счетчик *counter* для подсчета числа строк с длиной менее либо равной *maxLength*.

3. В цикле перебираются все элементы *inputArray* и проверяются на условие *длина строки <= maxLength*. Если условие выполняется, счетчик увеличивается на единицу.

4. Создается новый массив *outputArray* с размером, равным найденному числу строк.

5. В цикле повторно перебираются все элементы *inputArray* и проверяются на условие *длина строки <= maxLength*. Если условие выполняется, строка копируется в массив *outputArray*.

6. Метод возвращает массив строк *outputArray*.


P.S. Хотелось бы конечно просто сцеплять все найденные строки в строку с разделителем, а потом методом String.Split преобразовать в массив строк и не проходить по массиву два раза, но это будет работать только если символа-разделителя заведомо нет в данных.