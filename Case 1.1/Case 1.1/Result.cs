using System;
using System.Drawing;

public class Result
{
    public static string plan;
    public static bool proverka;
    public static double resultStal; // Руда
    public static double resultNikel; // Никель
    public static double resultChrome; // Хром
    public static double resultMarganec; // Марганец
    public static double resultPech; // Время доменной печи
    public static double resultConvert; // Время конвертера
    public static double resultProkat; // Время прокатного стана
    public static double resultRub; // Общая прибыль
    public void result()
    {
        // Создаем объекты для доступных ресурсов и марок стали
        Reader Mark = new Reader();
        Marka_A marka_A = new Marka_A();
        Marka_B marka_B = new Marka_B();
        Marka_C marka_C = new Marka_C();

        // Рассчитываем потребление ресурсов для производства
        resultStal = marka_A.ruda_stileA * Reader.Mark_A + marka_B.ruda_stileB * Reader.Mark_B + marka_C.ruda_stileC * Reader.Mark_C; // Руда
        resultNikel = marka_A.nikelA * Reader.Mark_A + marka_B.nikelB * Reader.Mark_B + marka_C.nikelC * Reader.Mark_C; // Никель
        resultChrome = marka_A.chromeA * Reader.Mark_A + marka_B.chromeB * Reader.Mark_B + marka_C.chromeC * Reader.Mark_C; // Хром
        resultMarganec = marka_A.marganecA * Reader.Mark_A + marka_B.marganecB * Reader.Mark_B + marka_C.marganecC * Reader.Mark_C; // Марганец
        resultPech = marka_A.pechA * Reader.Mark_A + marka_B.pechB * Reader.Mark_B + marka_C.pechC * Reader.Mark_C; // Время доменной печи
        resultConvert = marka_A.convertA * Reader.Mark_A + marka_B.convertB * Reader.Mark_B + marka_C.convertC * Reader.Mark_C; // Время конвертера
        resultProkat = marka_A.prokatA * Reader.Mark_A + marka_B.prokatB * Reader.Mark_B + marka_C.prokatC * Reader.Mark_C; // Время прокатного стана
        resultRub = marka_A.rubA * Reader.Mark_A + marka_B.rubB * Reader.Mark_B + marka_C.rubC * Reader.Mark_C; // Общая прибыль

        // Проверяем, достаточно ли ресурсов для производства
        if (resultStal <= DostupResur.ruda && resultNikel <= DostupResur.nikel && resultChrome <= DostupResur.chrome &&
            resultMarganec <= DostupResur.marganec && resultPech <= DostupResur.pech && resultConvert <= DostupResur.convert &&
            resultProkat <= DostupResur.prokat)
        {
            proverka = true;
            // Выводим результаты, если ресурсов хватает
            plan = $"Марка стали A: {Reader.Mark_A} тонн \r\nМарка стали B: {Reader.Mark_B} тонн \r\nМарка стали C: {Reader.Mark_C} тонн \r\n" +
                $"\nИспользованные ресурсы: \r\nРуда: {resultStal} тонн \r\nНикель: {resultNikel} кг \r\nХром: {resultChrome} кг \r\nМарганец: {resultMarganec} " +
                $"кг \r\nВремя работы доменной печи: {resultPech} часов \r\nВремя работы конвертера: {resultConvert} часов" +
                $" \r\nВремя работы прокатного стана: {resultProkat} часов \r\nОбщая прибыль: {resultRub} руб.\r\n";
        }
        else
        {
            proverka = false;
            // Выводим сообщение, если ресурсов недостаточно
            plan = "Недостаточно ресурсов или неправильный ввод!";
        }
    }
    public void minus()
    {  
        DostupResur.ruda = DostupResur.ruda - resultStal;    
        DostupResur.nikel = DostupResur.chrome - resultNikel;
        DostupResur.chrome = DostupResur.chrome - resultChrome;
        DostupResur.marganec = DostupResur.marganec - resultMarganec;
        DostupResur.pech = DostupResur.pech - resultPech;
        DostupResur.convert = DostupResur.convert - resultConvert;
        DostupResur.prokat = DostupResur.prokat - resultProkat;
        plan = $"Файл успешно сохранен\r\nОставшиеся ресурсы:\r\nРуда (тонн): {DostupResur.ruda}" +
            $"\r\nНикель (кг): {DostupResur.nikel}\r\nХром (кг): {DostupResur.chrome}\r\nМарганец (кг): {DostupResur.marganec}" +
            $"\r\nВремя работы доменной печи (часы): {DostupResur.pech}\r\nВремя работы конвертера (часы): {DostupResur.convert}" +
            $"\r\nВремя работы прокатного стана (часы): {DostupResur.prokat}\r\n"; 
    }
}