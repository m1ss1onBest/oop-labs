#include "b1.h"

#include <iostream>

b1::b1(std::string val)
    : value(std::move(val))
{
    display();
}

void b1::display() const
{
    std::cout << typeid(*this).name() << ' ' << value << '\n' << std::flush;
}
