module;
#include "iostream"
#include "string"
#include "format"

import display;
import processor;
import ram;
import battery;

export module laptop;
export class laptop
{
    std::string name;
    screen top_screen = screen();
    processor proc;
    ram mem;
    battery bat;

public:
    laptop() = default;
    laptop(std::string name, const screen& screen, const processor& processor, const ram& ram, const battery& battery) :
    name(std::move(name)), proc(processor), mem(ram), bat(battery)
    {
        
    }

    // std::string format()
    // {
        // return std::format("laptop {}, with parameters {}, {}, {}, {}.", name, top_screen.format(), proc.format(), mem.format(), bat.format());
    // }

    // void display()
    // {
        // std::cout << format() + '\n';
    // }
    
};