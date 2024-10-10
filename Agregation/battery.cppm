module;

#include "iostream"
#include "string"
#include "format"

export module battery;
export class battery
{
    std::string name;
    int capacity;

public:
    battery() = default;
    battery(std::string name, int capacity) :
    name(std::move(name)),
    capacity(capacity)
    {
        
    }

    // std::string format()
    // {
        // return std::format("battery {} with {} capacity", name, capacity);
    // }

    // void display()
    // {
        // std::cout << format() + '\n';
    // }
};