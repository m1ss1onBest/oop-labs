module;
#include "iostream"
#include "string"
#include "utility"
#include "format"

export module engine;
export class engine
{
    std::string fuel;
    uint16_t horse_powers;
    uint8_t cylinders;

public:
    engine() : fuel("none"), horse_powers(0), cylinders(0)
    {
        std::cout << "new empty engine created at: " << this << '\n';
    }
    
    engine(std::string fuel_type, const uint16_t horse_powers, uint8_t cylinders) :
    fuel(std::move(fuel_type)),
    horse_powers(horse_powers),
    cylinders(cylinders)
    {
        std::cout << "new engine created at : " << this << '\n';
    }

    std::string format()
    {
        return std::format("Engine(fuel-type: {}, horse-powers: {}, cylinders: {})", fuel, horse_powers, cylinders);
    }

    void display()
    {
        std::cout << format() + '\n';
    }

    std::string& get_fuel_type()
    {
        return fuel;
    }

    uint16_t get_horse_powers() const
    {
        return horse_powers;
    }

    uint8_t get_cylinders() const
    {
        return cylinders;
    }

    void set_horse_powers(uint16_t new_value)
    {
        horse_powers = new_value;
    }

    void set_cylinders(uint8_t new_value)
    {
        cylinders = new_value;
    }
};