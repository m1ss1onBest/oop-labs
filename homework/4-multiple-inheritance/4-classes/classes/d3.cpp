#include "d3.h"

#include <iostream>

d3::d3(const std::string& val, const std::string& val2, std::string selfValue)
    : d1(val, val2)
{
    value = std::move(selfValue);
    std::cout << typeid(*this).name() << ' ' << value << '\n' << std::flush;
}
