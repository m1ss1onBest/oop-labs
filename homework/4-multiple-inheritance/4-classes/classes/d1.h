#pragma once

#include <string>

#include "b1.h"
#include "b2.h"

class d1 : public b1, b2
{
public:
    explicit d1(std::string val, std::string val2);
    ~d1() = default;
};
