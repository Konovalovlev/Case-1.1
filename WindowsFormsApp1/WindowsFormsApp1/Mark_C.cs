using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс, описывающий характеристики марки стали C
public class Marka_C   
{
    // Потребление руды на 1 тонну стали (в тоннах)
    public double ruda_stileC = 1;
    // Потребление никеля на 1 тонну стали (в кг)
    public double nikelC = 0;
    // Потребление хрома на 1 тонну стали (в кг)
    public double chromeC = 0;
    // Потребление марганца на 1 тонну стали (в кг)
    public double marganecC = 0;
    // Время работы доменной печи на 1 тонну стали (в часах)
    public double pechC = 0.3;
    // Время работы конвертера на 1 тонну стали (в часах)
    public double convertC = 0.2;
    // Время работы прокатного стана на 1 тонну стали (в часах)
    public double prokatC = 0.2;
    // Прибыль с 1 тонны стали (в рублях)
    public double rubC = 8000;
}

