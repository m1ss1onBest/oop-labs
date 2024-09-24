#pragma once
#include "d2.h"

class d4 : public d2
{
public:
    std::string value;

    d4(std::string val, std::string val2, std::string selfValue);
    ~d4() = default;

    void display() const;
};
