export module brush;

#include "string"
#include "format"
#include <iostream>

export class brush
{
    std::string color = "000000";
    uint8_t radius = 1;

    static brush* self;

    brush() = default;
    brush(std::string color, uint8_t radius) : color(std::move(color)), radius(radius)
    {
        
    }

    static void check_or_init()
    {
        if (self == nullptr)
        {
            self = new brush();
        }
    }

public:
    static brush* get_instance()
    {
        check_or_init();
        return self;
    }

    static void set_color(std::string color)
    {
        check_or_init();
        self->color = std::move(color);
    }

    static void set_radius(uint8_t radius)
    {
        check_or_init();
        self->radius = radius;
    }

    static void create_new(std::string color, uint8_t radius)
    {
        delete self;
        self = new brush(std::move(color), radius);
    }

    static void destroy_instance()
    {
        delete self;
        self = nullptr;
    }

    static void display()
    {
        if (self == nullptr)
        {
            std::cout << "nullptr\n";
        }
        else
        {
            std::cout << std::format("Brush({}, {}px)\n", self->color, self->radius);
        }
    }
};

brush* brush::self = nullptr;