module;

#include "string"
#include "format"
#include "iostream"

export module display;
export class screen
{
    std::string name = "unknown";
    std::string type = "amoled";
    int width = 1920;
    int height = 1080;

public:
    screen() = default;
    screen(std::string name, std::string type, int w, int h) :
    name(std::move(name)),
    type(std::move(type)),
    width(w), height(h)
    {
        
    }

    std::string format()
    {
        return std::format("{} display {} {}x{})", type, name, width, height);
    }

    void display()
    {
        std::cout << format();
    }
};