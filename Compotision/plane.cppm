module;
#include "iostream"
#include "string"
#include "format"

export module plane;
import engine;

export class plane
{
    std::string name;
    uint16_t max_height;
    uint32_t fuel_tank_capacity;
    engine plane_engine;

public:
    std::string format()
    {
        return std::format("Plane(name: {}, max_h: {}, fuel_cap: {}, {})", name, max_height, fuel_tank_capacity, plane_engine.format());
    }

    void display()
    {
        std::cout << format() + '\n';
    }
    
    class builder
    {
        std::string name = "none";
        uint16_t height = 0;
        uint32_t fuel_tank = 0;
        engine eg = engine();

    public:
        builder& set_name(const std::string& plane_name)
        {
            name = plane_name;
            return *this;
        }

        builder& set_max_height(uint16_t max_height)
        {
            height = max_height;
            return *this;
        }

        builder set_fuel_tank_capacity(uint32_t capacity)
        {
            fuel_tank = capacity;
            return *this;
        }

        builder& set_engine_power(uint16_t engine_power)
        {
            eg.set_horse_powers(engine_power);
            return *this;
        }

        builder& set_engine(const engine& new_engine)
        {
            eg = new_engine;
            return *this;
        }

        builder& set_engine_cylinders(uint8_t cylinders)
        {
            eg.set_cylinders(cylinders);
            return *this;
        }

        builder& set_fuel_type(const std::string& fuel_type)
        {
            eg.get_fuel_type() = fuel_type;
            return *this;
        }

        plane construct() const
        {
            plane p = plane();
            p.name = name;
            p.max_height = height;
            p.fuel_tank_capacity = fuel_tank;
            p.plane_engine = eg;
            return  p;
        }
    };
    
    plane() : name("none"), max_height(0), fuel_tank_capacity(0), plane_engine(engine())
    {
        std::cout << "created new plane at : " << this << '\n';
    }
};