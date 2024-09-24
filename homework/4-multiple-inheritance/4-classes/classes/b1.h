#pragma once

#include <string>

class b1
{
public:
    std::string value;

    explicit b1(std::string val);
    ~b1() = default;

    void display() const;
};
