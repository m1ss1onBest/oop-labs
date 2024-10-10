module;

#include "iostream"
#include "string"
#include "format"

export module ram;
export class ram
{
    std::string name;
    int capacity;

public:
    ram() = default;
    ram(std::string name, int capacity) :
    name(std::move(name)),
    capacity(capacity)
    {
        
    }

    // std::string format()
    // {
        // return std::format("{} ram {}", name, capacity);
    // }

    // void display()
    // {
        // std::cout << format() + '\n';
    // }
};