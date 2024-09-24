#include "d1.h"

#include <iostream>

#include "b1.h"

d1::d1(std::string val, std::string val2)
    : b1(std::move(val)), b2(std::move(val2))
{
    std::cout << typeid(*this).name() <<'\n' << std::flush;
}


