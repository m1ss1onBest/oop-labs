#pragma once

#include "b2.h"

class d2 : protected b2
{
public:
    std::string value;
    
    explicit d2(std::string val, std::string selfValue);
    ~d2() = default;

    void display() const;
    
};
