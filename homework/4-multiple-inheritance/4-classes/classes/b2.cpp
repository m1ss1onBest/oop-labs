#include "b2.h"

#include <iostream>

b2::b2(std::string val)
    : value(std::move(val))
{
    display();
}

void b2::display() const
{
    std::cout << typeid(*this).name() << ' ' << value << '\n' << std::flush;
}
