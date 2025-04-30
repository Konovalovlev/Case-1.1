using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс, описывающий характеристики марки стали A
    
public class Marka_A   
{
    // Потребление руды на 1 тонну стали (в тоннах)
    public double _rudaStileA = 2;
    // Потребление никеля на 1 тонну стали (в кг)
    public double _nikelA = 0.5;
    // Потребление хрома на 1 тонну стали (в кг)
    public double _chromeA = 0;
    // Потребление марганца на 1 тонну стали (в кг)
    public double _marganecA = 0;
    // Время работы доменной печи на 1 тонну стали (в часах)
    public double _pechA = 0.5;
    // Время работы конвертера на 1 тонну стали (в часах)
    public double _convertA = 0.2;
    // Время работы прокатного стана на 1 тонну стали (в часах)
    public double _prokatA = 0.3;
    // Прибыль с 1 тонны стали (в рублях)
    public double _rubA = 10000;    
}