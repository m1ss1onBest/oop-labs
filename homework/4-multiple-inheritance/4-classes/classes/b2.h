#pragma once

#include <string>

class b2
{
public:
    std::string value;

    explicit b2(std::string val);
    ~b2() = default;

    void display() const;
};
