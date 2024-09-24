#pragma once
#include <utility>

#include "d1.h"

class d3 : protected d1
{
private:
    std::string value;
    
public:
    d3(const std::string& val, const std::string& val2, std::string selfValue);
    void display() const;
};
