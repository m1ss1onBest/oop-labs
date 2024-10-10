#include "format"
#include "iostream"

import battery;
import display;
import ram;
import processor;
import laptop;

int main(int argc, char* argv[])
{
    battery laptop_battery = battery("battery", 57);
    screen laptop_display = screen("Super ultra samsung", "o-led", 1980, 1080);
    ram laptop_ram = ram("monsterX", 2048);
    processor laptop_processor("intel core i5", 17, 5.50f);

    laptop best_laptop_ever = laptop("Legion Lenovo", laptop_display, laptop_processor, laptop_ram, laptop_battery);

    return 0;
}
