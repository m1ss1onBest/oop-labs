#include "d4.h"

#include <iostream>

d4::d4(std::string val, std::string val2, std::string selfValue)
    : d2(val, val2)
{
    value = selfValue;
    display();
}


void d4::display() const
{
    std::cout << typeid(*this).name() << ' ' << value << '\n' << std::flush;
}
