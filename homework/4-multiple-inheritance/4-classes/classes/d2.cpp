#include "d2.h"

#include <iostream>
#include <utility>

d2::d2(std::string val, std::string selfValue)
    : b2(std::move(val))
{
    value = std::move(selfValue);
    display();
}

void d2::display() const
{
    std::cout << typeid(*this).name() << ' ' << value << '\n' << std::flush;
}
