using System;
using System.Drawing;

public class Result
{
    public static string _plan;//Стринговая пременная используемая для записи информации в текст бокс
    public static bool _proverka;// Булевая переменная используемая для проверки
    public static double _resultStal; // Руда
    public static double _resultNikel; // Никель
    public static double _resultChrome; // Хром
    public static double _resultMarganec; // Марганец
    public static double _resultPech; // Время доменной печи
    public static double _resultConvert; // Время конвертера
    public static double _resultProkat; // Время прокатного стана
    public static double _resultRub; // Общая прибыль
    public void result()
    {
        // Создаем объекты для доступных ресурсов и марок стали
        Reader Mark = new Reader();
        Marka_A marka_A = new Marka_A();
        Marka_B marka_B = new Marka_B();
        Marka_C marka_C = new Marka_C();

        // Рассчитываем потребление ресурсов для производства
        _resultStal = marka_A._rudaStileA * Reader._mark_A + marka_B._rudaStileB * Reader._mark_B + marka_C._rudaStileC * Reader._mark_C; // Руда
        _resultNikel = marka_A._nikelA * Reader._mark_A + marka_B._nikelB * Reader._mark_B + marka_C._nikelC * Reader._mark_C; // Никель
        _resultChrome = marka_A._chromeA * Reader._mark_A + marka_B._chromeB * Reader._mark_B + marka_C._chromeC * Reader._mark_C; // Хром
        _resultMarganec = marka_A._marganecA * Reader._mark_A + marka_B._marganecB * Reader._mark_B + marka_C._marganecC * Reader._mark_C; // Марганец
        _resultPech = marka_A._pechA * Reader._mark_A + marka_B._pechB * Reader._mark_B + marka_C._pechC * Reader._mark_C; // Время доменной печи
        _resultConvert = marka_A._convertA * Reader._mark_A + marka_B._convertB * Reader._mark_B + marka_C._convertC * Reader._mark_C; // Время конвертера
        _resultProkat = marka_A._prokatA * Reader._mark_A + marka_B._prokatB * Reader._mark_B + marka_C._prokatC * Reader._mark_C; // Время прокатного стана
        _resultRub = marka_A._rubA * Reader._mark_A + marka_B._rubB * Reader._mark_B + marka_C._rubC * Reader._mark_C; // Общая прибыль

        // Проверяем, достаточно ли ресурсов для производства
        if (_resultStal <= DostupResur._ruda && _resultNikel <= DostupResur._nikel && _resultChrome <= DostupResur._chrome &&
            _resultMarganec <= DostupResur._marganec && _resultPech <= DostupResur._pech && _resultConvert <= DostupResur._convert &&
            _resultProkat <= DostupResur._prokat)
        {
            _proverka = true;
            // Выводим результаты, если ресурсов хватает
            _plan = $"Марка стали A: {Reader._mark_A} тонн \r\nМарка стали B: {Reader._mark_B} тонн \r\nМарка стали C: {Reader._mark_C} тонн \r\n" +
                $"\nИспользованные ресурсы: \r\nРуда: {_resultStal} тонн \r\nНикель: {_resultNikel} кг \r\nХром: {_resultChrome} кг \r\nМарганец: {_resultMarganec} " +
                $"кг \r\nВремя работы доменной печи: {_resultPech} часов \r\nВремя работы конвертера: {_resultConvert} часов" +
                $" \r\nВремя работы прокатного стана: {_resultProkat} часов \r\nОбщая прибыль: {_resultRub} руб.\r\n";
        }
        else
        {
            _proverka = false;
            // Выводим сообщение, если ресурсов недостаточно
            _plan = "Недостаточно ресурсов или неправильный ввод!";
        }
    }
    public void minus()
    {  
        DostupResur._ruda = DostupResur._ruda - _resultStal;    
        DostupResur._nikel = DostupResur._chrome - _resultNikel;
        DostupResur._chrome = DostupResur._chrome - _resultChrome;
        DostupResur._marganec = DostupResur._marganec - _resultMarganec;
        DostupResur._pech = DostupResur._pech - _resultPech;
        DostupResur._convert = DostupResur._convert - _resultConvert;
        DostupResur._prokat = DostupResur._prokat - _resultProkat;
        _plan = $"Файл успешно сохранен\r\nОставшиеся ресурсы:\r\nРуда (тонн): {DostupResur._ruda}" +
            $"\r\nНикель (кг): {DostupResur._nikel}\r\nХром (кг): {DostupResur._chrome}\r\nМарганец (кг): {DostupResur._marganec}" +
            $"\r\nВремя работы доменной печи (часы): {DostupResur._pech}\r\nВремя работы конвертера (часы): {DostupResur._convert}" +
            $"\r\nВремя работы прокатного стана (часы): {DostupResur._prokat}\r\n"; 
    }
}