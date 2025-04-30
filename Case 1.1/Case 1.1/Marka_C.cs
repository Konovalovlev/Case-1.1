using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс, описывающий характеристики марки стали C
public class Marka_C   
{
    // Потребление руды на 1 тонну стали (в тоннах)
    public double _rudaStileC = 1;
    // Потребление никеля на 1 тонну стали (в кг)
    public double _nikelC = 0;
    // Потребление хрома на 1 тонну стали (в кг)
    public double _chromeC = 0;
    // Потребление марганца на 1 тонну стали (в кг)
    public double _marganecC = 0;
    // Время работы доменной печи на 1 тонну стали (в часах)
    public double _pechC = 0.3;
    // Время работы конвертера на 1 тонну стали (в часах)
    public double _convertC = 0.2;
    // Время работы прокатного стана на 1 тонну стали (в часах)
    public double _prokatC = 0.2;
    // Прибыль с 1 тонны стали (в рублях)
    public double _rubC = 8000;
}

